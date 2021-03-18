namespace Server.Items
{
    public class LargeStoneTableEastAddon : BaseAddon
    {
        public override BaseAddonDeed Deed => new LargeStoneTableEastDeed();


        [Constructible]
        public LargeStoneTableEastAddon() : this(0)
        {
        }


        [Constructible]
        public LargeStoneTableEastAddon(int hue)
        {
            AddComponent(new AddonComponent(0x1202), 0, 0, 0);
            AddComponent(new AddonComponent(0x1203), 0, 1, 0);
            AddComponent(new AddonComponent(0x1201), 0, 2, 0);
            Hue = hue;
        }

        [Constructible]
        public LargeStoneTableEastAddon(Serial serial) : base(serial)
        {
        }

        public override void Serialize(IGenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int) 1); // version
        }

        public override void Deserialize(IGenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }
    }

    public class LargeStoneTableEastDeed : BaseAddonDeed
    {
        public override BaseAddon Addon => new LargeStoneTableEastAddon(Hue);

        public override int LabelNumber => 1044511; // large stone table (east)


        public LargeStoneTableEastDeed()
        {
        }

        public LargeStoneTableEastDeed(Serial serial) : base(serial)
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