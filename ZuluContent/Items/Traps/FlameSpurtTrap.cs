using System;
using Server.Spells;

namespace Server.Items
{
    public class FlameSpurtTrap : BaseTrap
    {
        private Item m_Spurt;
        private Timer m_Timer;


        [Constructible]
        public FlameSpurtTrap() : base(0x1B71)
        {
            Visible = false;
        }

        public virtual void StartTimer()
        {
            if (m_Timer == null)
                m_Timer = Timer.DelayCall(TimeSpan.FromSeconds(1.0), TimeSpan.FromSeconds(1.0), Refresh);
        }

        public virtual void StopTimer()
        {
            if (m_Timer != null)
                m_Timer.Stop();

            m_Timer = null;
        }

        public virtual void CheckTimer()
        {
            var map = Map;

            if (map != null && map.GetSector(GetWorldLocation()).Active)
                StartTimer();
            else
                StopTimer();
        }

        public override void OnLocationChange(Point3D oldLocation)
        {
            base.OnLocationChange(oldLocation);

            CheckTimer();
        }

        public override void OnMapChange()
        {
            base.OnMapChange();

            CheckTimer();
        }

        public override void OnSectorActivate()
        {
            base.OnSectorActivate();

            StartTimer();
        }

        public override void OnSectorDeactivate()
        {
            base.OnSectorDeactivate();

            StopTimer();
        }

        public override void OnDelete()
        {
            base.OnDelete();

            if (m_Spurt != null)
                m_Spurt.Delete();
        }

        public virtual void Refresh()
        {
            if (Deleted)
                return;

            var foundPlayer = false;

            foreach (var mob in GetMobilesInRange(3))
            {
                if (!mob.Player || !mob.Alive || mob.AccessLevel > AccessLevel.Player)
                    continue;

                if (Z + 8 >= mob.Z && mob.Z + 16 > Z)
                {
                    foundPlayer = true;
                    break;
                }
            }

            if (!foundPlayer)
            {
                if (m_Spurt != null)
                    m_Spurt.Delete();

                m_Spurt = null;
            }
            else if (m_Spurt == null || m_Spurt.Deleted)
            {
                m_Spurt = new Static(0x3709);
                m_Spurt.MoveToWorld(Location, Map);

                Effects.PlaySound(GetWorldLocation(), Map, 0x309);
            }
        }

        public override bool OnMoveOver(Mobile mobile)
        {
            if (mobile.AccessLevel > AccessLevel.Player)
                return true;

            if (mobile.Player && mobile.Alive)
            {
                CheckTimer();

                SpellHelper.Damage(Utility.RandomMinMax(1, 30), mobile, mobile);

                mobile.PlaySound(mobile.Female ? 0x327 : 0x437);
            }

            return false;
        }

        public override void OnMovement(Mobile m, Point3D oldLocation)
        {
            base.OnMovement(m, oldLocation);

            if (m.Location == oldLocation || !m.Player || !m.Alive || m.AccessLevel > AccessLevel.Player)
                return;

            if (CheckRange(m.Location, oldLocation, 1))
            {
                CheckTimer();

                SpellHelper.Damage(Utility.RandomMinMax(1, 10), m, m, null, TimeSpan.FromTicks(1));

                m.PlaySound(m.Female ? 0x327 : 0x437);

                if (m.Body.IsHuman)
                    m.Animate(20, 1, 1, true, false, 0);
            }
        }

        [Constructible]
        public FlameSpurtTrap(Serial serial) : base(serial)
        {
        }

        public override void Serialize(IGenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int) 0); // version

            writer.Write((Item) m_Spurt);
        }

        public override void Deserialize(IGenericReader reader)
        {
            base.Deserialize(reader);

            var version = reader.ReadInt();

            switch (version)
            {
                case 0:
                {
                    var item = reader.ReadEntity<Item>();

                    if (item != null)
                        item.Delete();

                    CheckTimer();

                    break;
                }
            }
        }
    }
}