using System;
using Server.Mobiles;

namespace Server.Spells.Eighth
{
    public class SummonDaemonSpell : MagerySpell
    {
        public SummonDaemonSpell(Mobile caster, Item spellItem) : base(caster, spellItem)
        {
        }

        public override void OnCast()
        {
            if (CheckSequence())
            {
                var duration = TimeSpan.FromSeconds(2 * Caster.Skills.Magery.Fixed / 5);

                SpellHelper.Summon(new Daemon(), Caster, 0x216, duration, false, false);
            }

            FinishSequence();
        }
    }
}