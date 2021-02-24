namespace Server.Items
{
    public class WoodenKiteShield : BaseShield
    {
        public override int InitMinHits => 70;

        public override int InitMaxHits => 70;

        public override int ArmorBase => 16;

        public override int DefaultStrReq => 20;


        [Constructible]
        public WoodenKiteShield() : base(0x1B79)
        {
            Weight = 5.0;
        }

        [Constructible]
        public WoodenKiteShield(Serial serial) : base(serial)
        {
        }

        public override void Deserialize(IGenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();

            if (Weight == 7.0)
                Weight = 5.0;
        }

        public override void Serialize(IGenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int) 0); //version
        }
    }
}