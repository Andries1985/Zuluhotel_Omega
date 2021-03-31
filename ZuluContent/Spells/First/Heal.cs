using System;
using System.Threading.Tasks;
using Scripts.Zulu.Utilities;
using Server.Engines.Magic;
using Server.Mobiles;
using Server.Network;
using Server.Targeting;
using ZuluContent.Zulu.Engines.Magic;
#pragma warning disable 1998

namespace Server.Spells.First
{
    public class HealSpell : MagerySpell, ITargetableAsyncSpell<Mobile>
    {
        public HealSpell(Mobile caster, Item spellItem = null) : base(caster, spellItem) { }

        public async Task OnTargetAsync(ITargetResponse<Mobile> response)
        {
            if (!response.HasValue)
                return;
            
            var mobile = response.Target;

            SpellHelper.Turn(Caster, mobile);
            var healed = Utility.Random(1, 6) + Caster.Skills[SkillName.Magery].Value / 20 + 5;
            
            Caster.FireHook(h => h.OnModifyWithMagicEfficiency(Caster, ref healed));
            
            // Cheating here, it's 20 for non-classed and 30 for classed mages
            // But we don't want to tightly couple the spell to the Mage class, it could be Priest etc later 
            const int maxHeal = 30;
            if (healed > maxHeal)
                healed = maxHeal;
            
            mobile.FixedParticles(0x376A, 9, 32, 5005, EffectLayer.Waist);
            mobile.PlaySound(0x1F2);

            if (mobile is BaseCreature {CreatureType: CreatureType.Undead})
                SpellHelper.Damage((int) healed, mobile, Caster, this);
            else
            {
                SpellHelper.Heal((int) healed, mobile, Caster, this);
                Caster.SendSuccessMessage($"You healed {(int) healed} damage.");
            }
        }
    }
}