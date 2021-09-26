using System;
using MessagePack;
using Server;
using Server.Engines.Magic;
using Server.Spells;
using ZuluContent.Zulu.Engines.Magic.Enums;

namespace ZuluContent.Zulu.Engines.Magic.Enchantments
{
    [MessagePackObject]
    public class FireProtection : Enchantment<FireProtectionInfo>, IDistinctEnchantment
    {
        [IgnoreMember]
        private int m_Value = 0;

        [IgnoreMember]
        public override string AffixName => EnchantmentInfo.GetName(
            IElementalResistible.GetProtectionLevelForResist(Value), Cursed);

        [Key(1)]
        public int Value
        {
            get => Cursed > CurseType.None ? -m_Value : m_Value;
            set => m_Value = value;
        }
        
        [CallPriority(1)]
        public override bool GetShouldDye() => true;

        public override void OnSpellDamage(Mobile attacker, Mobile defender, Spell spell, ElementalType damageType,
            ref int damage)
        {
            if (damageType == ElementalType.Fire) 
                damage -= (int) (damage * ((double) Value / 100));
        }
        
        public int CompareTo(object obj) => obj switch
        {
            FireProtection other => ReferenceEquals(this, other) ? 0 : m_Value.CompareTo(other.m_Value),
            null => 1,
            _ => throw new ArgumentException($"Object must be of type {GetType().FullName}")
        };
    }

    public class FireProtectionInfo : EnchantmentInfo
    {
        public override string Description { get; protected set; } = "Elemental Fire Protection";
        public override EnchantNameType Place { get; protected set; } = EnchantNameType.Suffix;

        public override string[,] Names { get; protected set; } =
            MakeProtNames("Fire", IEnchantmentInfo.DefaultElementalProtectionNames);

        public override int Hue { get; protected set; } = 240;
        public override int CursedHue { get; protected set; } = 240;
    }
}