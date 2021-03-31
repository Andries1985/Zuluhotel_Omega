using System;
using System.Threading.Tasks;
using Server.Targeting;
using ZuluContent.Zulu.Engines.Magic.Enchantments.Buffs;

namespace Server.Spells.Second
{
    public class AgilitySpell : MagerySpell, ITargetableAsyncSpell<Mobile>
    {
        public AgilitySpell(Mobile caster, Item spellItem = null) : base(caster, spellItem) { }
        
        public async Task OnTargetAsync(ITargetResponse<Mobile> response)
        {
            if (!response.HasValue)
                return;
            
            var target = response.Target;
            
            if (!Caster.CanBuff(target, icons: BuffIcon.Agility))
                return;
            
            target.TryAddBuff(new StatBuff(StatType.Dex)
            {
                Value = SpellHelper.GetModAmount(Caster, target, StatType.Dex),
                Duration = SpellHelper.GetDuration(Caster, target),
            });
            SpellHelper.Turn(Caster, target);

            target.FixedParticles(0x375A, 10, 15, 5010, EffectLayer.Waist);
            target.PlaySound(0x1e7);
        }
    }
}