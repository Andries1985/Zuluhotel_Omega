namespace Server.Items
{
    public class StarSapphire : Item
    {
        public override double DefaultWeight { get; } = 0.1;

        [Constructible]
        public StarSapphire() : this(1)
        {
        }


        [Constructible]
        public StarSapphire(int amount) : base(0xF21)
        {
            Stackable = true;
            Amount = amount;
        }

        [Constructible]
        public StarSapphire(Serial serial) : base(serial)
        {
        }


        public override void Serialize(IGenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int) 0); // version
        }

        public override void Deserialize(IGenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }
    }
}