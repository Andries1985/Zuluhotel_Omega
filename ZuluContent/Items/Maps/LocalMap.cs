namespace Server.Items
{
    public class LocalMap : MapItem
    {
        [Constructible]
        public LocalMap()
        {
            SetDisplay(0, 0, 5119, 4095, 400, 400);
        }

        public override void CraftInit(Mobile from)
        {
            double skillValue = from.Skills[SkillName.Cartography].Value;
            int dist = 64 + (int) (skillValue * 2);

            SetDisplay(from.X - dist, from.Y - dist, from.X + dist, from.Y + dist, 200, 200);
        }

        public override int LabelNumber
        {
            get { return 1015230; }
        } // local map

        [Constructible]
        public LocalMap(Serial serial) : base(serial)
        {
        }

        public override void Serialize(IGenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int) 0);
        }

        public override void Deserialize(IGenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }
    }
}