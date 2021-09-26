namespace Server.Items
{
    public class Fish : Item, ICarvable
    {
        public void Carve(Mobile from, Item item)
        {
            base.ScissorHelper(from, new RawFishSteak(), 4);
        }
        
        public override double DefaultWeight => 0.5;

        [Constructible]
        public Fish() : this(1)
        {
        }

        [Constructible]
        public Fish(int amount) : base(Utility.Random(0x09CC, 4))
        {
            Stackable = true;
            Amount = amount;
        }

        [Constructible]
        public Fish(Serial serial) : base(serial)
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