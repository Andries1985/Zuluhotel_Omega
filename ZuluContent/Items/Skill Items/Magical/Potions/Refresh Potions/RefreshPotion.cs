namespace Server.Items
{
    public class RefreshPotion : BaseRefreshPotion
    {
        public override uint PotionStrength { get; set; } = 1;

        public override double Refresh { get; } = 0.25;


        [Constructible]
        public RefreshPotion() : base(PotionEffect.Refresh)
        {
        }

        [Constructible]
        public RefreshPotion(Serial serial) : base(serial)
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