namespace Server.Items
{
    public class Nightshade : BaseReagent
    {
        [Constructible]
        public Nightshade() : this(1)
        {
        }


        [Constructible]
        public Nightshade(int amount) : base(0xF88, amount)
        {
        }

        [Constructible]
        public Nightshade(Serial serial) : base(serial)
        {
        }


        public override void Serialize(IGenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write(0); // version
        }

        public override void Deserialize(IGenericReader reader)
        {
            base.Deserialize(reader);

            var version = reader.ReadInt();
        }
    }
}