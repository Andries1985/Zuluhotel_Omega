using System;
using Server.Targeting;

namespace Server.Spells.Sixth
{
    public class ExplosionSpell : MagerySpell
    {
        public ExplosionSpell(Mobile caster, Item scroll)
            : base(caster, scroll)
        {
        }


        public override bool DelayedDamageStacking
        {
            get { return true; }
        }

        public override bool DelayedDamage
        {
            get { return false; }
        }


        public override void OnCast()
        {
            Caster.Target = new InternalTarget(this);
        }

        public void Target(Mobile m)
        {
            if (!Caster.CanSee(m))
            {
                Caster.SendLocalizedMessage(500237); // Target can not be seen.
            }
            else if (Caster.CanBeHarmful(m) && CheckSequence())
            {
                Mobile attacker = Caster, defender = m;

                SpellHelper.Turn(Caster, m);

                SpellHelper.CheckReflect((int) Circle, Caster, ref m);

                var t = new InternalTimer(this, attacker, defender, m);
                t.Start();
            }

            FinishSequence();
        }

        private class InternalTimer : Timer
        {
            private readonly Mobile m_Attacker;
            private readonly Mobile m_Defender;
            private readonly MagerySpell m_Spell;
            private readonly Mobile m_Target;

            public InternalTimer(MagerySpell spell, Mobile attacker, Mobile defender, Mobile target)
                : base(TimeSpan.FromSeconds(2.5))
            {
                m_Spell = spell;
                m_Attacker = attacker;
                m_Defender = defender;
                m_Target = target;

                m_Spell?.StartDelayedDamageContext(attacker, this);

                Priority = TimerPriority.FiftyMS;
            }

            protected override void OnTick()
            {
                if (m_Attacker.HarmfulCheck(m_Defender))
                {
                    double damage = Utility.Random(23, 22);

                    if (m_Spell.CheckResisted(m_Target))
                    {
                        damage *= 0.75;

                        m_Target.SendLocalizedMessage(501783); // You feel yourself resisting magical energy.
                    }

                    damage *= m_Spell.GetDamageScalar(m_Target);

                    m_Target.FixedParticles(0x36BD, 20, 10, 5044, EffectLayer.Head);
                    m_Target.PlaySound(0x307);

                    SpellHelper.Damage(damage, m_Defender, m_Attacker, m_Spell);

                    m_Spell?.RemoveDelayedDamageContext(m_Attacker);
                }
            }
        }

        private class InternalTarget : Target
        {
            private readonly ExplosionSpell m_Owner;

            public InternalTarget(ExplosionSpell owner)
                : base(12, false, TargetFlags.Harmful)
            {
                m_Owner = owner;
            }

            protected override void OnTarget(Mobile from, object o)
            {
                if (o is Mobile)
                    m_Owner.Target((Mobile) o);
            }

            protected override void OnTargetFinish(Mobile from)
            {
                m_Owner.FinishSequence();
            }
        }
    }
}