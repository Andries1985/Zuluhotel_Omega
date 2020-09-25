namespace Server.Items
{
    public abstract class BaseBracelet : BaseJewel
    {
        public override int BaseGemTypeNumber
        {
            get { return 1044221; }
        } // star sapphire bracelet

        public BaseBracelet(int itemID) : base(itemID, Layer.Bracelet)
        {
        }

        public BaseBracelet(Serial serial) : base(serial)
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

    public class GoldBracelet : BaseBracelet
    {
        [Constructible]
        public GoldBracelet() : base(0x1086)
        {
            Weight = 0.1;
        }

        [Constructible]
        public GoldBracelet(Serial serial) : base(serial)
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

    public class SilverBracelet : BaseBracelet
    {
        public SilverBracelet() : base(0x1F06)
        {
            Weight = 0.1;
        }

        public SilverBracelet(Serial serial) : base(serial)
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