namespace Server.Items
{
    public class EyeOfNewt : BaseReagent
    {
        [Constructible]
        public EyeOfNewt()
            : this(1)
        {
        }


        [Constructible]
        public EyeOfNewt(int amount)
            : base(0xF87, amount)
        {
        }

        [Constructible]
        public EyeOfNewt(Serial serial)
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