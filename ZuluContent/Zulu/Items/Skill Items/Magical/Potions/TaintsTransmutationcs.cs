using System;
using Server.Spells;
using Server.Spells.Seventh;
using ZuluContent.Zulu.Engines.Magic.Enchantments.Buffs;

namespace Server.Items
{
    public class TaintsTransmutationPotion : BaseTaintsTransmutationPotion
    {
        public override int Hue { get; set; } = 155;

        public override uint PotionStrength { get; set; } = 1;
        public override string DefaultName { get; } = "Taint's Minor Transmutation potion";

        public TaintsTransmutationPotion() : base(PotionEffect.TaintsTransmutation)
        {
        }

        public TaintsTransmutationPotion(Serial serial) : base(serial)
        {
        }

        public override void Serialize(IGenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int) 0); // version
        }

        public override void Deserialize(IGenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
        }
    }

    public class TaintsMajorTransmutationPotion : BaseTaintsTransmutationPotion
    {
        public override int Hue { get; set; } = 0;

        public override string DefaultName { get; } = "Taint's Major Transmutation potion";
        public override uint PotionStrength { get; set; } = 2;

        public TaintsMajorTransmutationPotion() : base(PotionEffect.TaintsMajorTransmutation)
        {
        }

        public TaintsMajorTransmutationPotion(Serial serial) : base(serial)
        {
        }

        public override void Serialize(IGenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int) 0); // version
        }

        public override void Deserialize(IGenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
        }
    }

    public abstract class BaseTaintsTransmutationPotion : BasePotion
    {

        public BaseTaintsTransmutationPotion(PotionEffect effect) : base(0xE2A, effect)
        {
        }

        public BaseTaintsTransmutationPotion(Serial serial) : base(serial)
        {
        }

        public override void Serialize(IGenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int) 0); // version
        }

        public override void Deserialize(IGenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
        }

        public bool Buff(Mobile from)
        {
            var entries = Utility.RandomList(PolymorphSpell.Groups);
            var idx = Utility.Random(entries.Length);
            var body = entries[idx].BodyId;

            var mod = (int) PotionStrength * 5 + idx;

            if (from.CanBuff(from, true, BuffIcon.Polymorph))
            {
                from.TryAddBuff(new Polymorph
                {
                    Title = DefaultName,
                    Duration = TimeSpan.FromSeconds(PotionStrength * 120),
                    StatMods = (StrMod: mod, DexMod: mod, IntMod: mod),
                    BodyMods = (body: body, bodyHue: 0)
                });
                return true;
            }

            return true;
        }

        public override void Drink(Mobile from)
        {
            if (Buff(from))
            {
                from.FixedEffect(0x3727, 10, 15);
                from.PlaySound(0x209);
                PlayDrinkEffect(from);
                Consume();
            }
        }
    }
}