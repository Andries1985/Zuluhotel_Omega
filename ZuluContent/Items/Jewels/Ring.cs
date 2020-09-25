namespace Server.Items
{
    public abstract class BaseRing : BaseJewel
    {
        public override int BaseGemTypeNumber
        {
            get { return 1044176; }
        } // star sapphire ring

        public BaseRing(int itemID) : base(itemID, Layer.Ring)
        {
        }

        public BaseRing(Serial serial) : base(serial)
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

    public class GoldRing : BaseRing
    {
        [Constructible]
        public GoldRing() : base(0x108a)
        {
            Weight = 0.1;
        }

        [Constructible]
        public GoldRing(Serial serial) : base(serial)
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

    public class SilverRing : BaseRing
    {
        public SilverRing() : base(0x1F09)
        {
            Weight = 0.1;
        }

        public SilverRing(Serial serial) : base(serial)
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