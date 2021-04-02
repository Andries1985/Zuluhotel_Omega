namespace Server.Items
{
    public class Pumice : BaseReagent
    {
        [Constructible]
        public Pumice()
            : this(1)
        {
        }


        [Constructible]
        public Pumice(int amount)
            : base(0xF8B, amount)
        {
        }

        [Constructible]
        public Pumice(Serial serial)
            : base(serial)
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