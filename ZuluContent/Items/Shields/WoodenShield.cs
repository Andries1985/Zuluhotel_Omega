namespace Server.Items
{
    public class WoodenShield : BaseShield
    {
        public override int InitMinHits => 70;

        public override int InitMaxHits => 70;

        public override int ArmorBase => 16;


        [Constructible]
        public WoodenShield() : base(0x1B7A)
        {
            Weight = 5.0;
        }

        [Constructible]
        public WoodenShield(Serial serial) : base(serial)
        {
        }

        public override void Deserialize(IGenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }

        public override void Serialize(IGenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int) 0); //version
        }
    }
}