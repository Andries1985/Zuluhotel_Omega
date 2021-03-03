using Server.Targeting;

namespace Server.Spells.Second
{
    public class HarmSpell : MagerySpell
    {
        public HarmSpell(Mobile caster, Item spellItem) : base(caster, spellItem)
        {
        }


        public override bool DelayedDamage
        {
            get { return false; }
        }


        public override void OnCast()
        {
            Caster.Target = new InternalTarget(this);
        }


        public override double GetSlayerDamageScalar(Mobile target)
        {
            return 1.0; //This spell isn't affected by slayer spellbooks
        }


        public void Target(Mobile m)
        {
            if (!Caster.CanSee(m))
            {
                Caster.SendLocalizedMessage(500237); // Target can not be seen.
            }
            else if (CheckHarmfulSequence(m))
            {
                SpellHelper.Turn(Caster, m);

                SpellHelper.CheckReflect((int) Circle, Caster, ref m);

                double damage = Utility.Random(1, 15);

                if (CheckResisted(m))
                {
                    damage *= 0.75;

                    m.SendLocalizedMessage(501783); // You feel yourself resisting magical energy.
                }

                damage *= GetDamageScalar(m);

                if (!m.InRange(Caster, 2))
                    damage *= 0.25; // 1/4 damage at > 2 tile range
                else if (!m.InRange(Caster, 1))
                    damage *= 0.50; // 1/2 damage at 2 tile range

                m.FixedParticles(0x374A, 10, 15, 5013, EffectLayer.Waist);
                m.PlaySound(0x1F1);

                SpellHelper.Damage(damage, m, Caster, this);
            }

            FinishSequence();
        }

        private class InternalTarget : Target
        {
            private readonly HarmSpell m_Owner;

            public InternalTarget(HarmSpell owner) : base(12, false, TargetFlags.Harmful)
            {
                m_Owner = owner;
            }

            protected override void OnTarget(Mobile from, object o)
            {
                if (o is Mobile) m_Owner.Target((Mobile) o);
            }

            protected override void OnTargetFinish(Mobile from)
            {
                m_Owner.FinishSequence();
            }
        }
    }
}