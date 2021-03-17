namespace Server.Items
{
    public class AnvilEastAddon : BaseAddon
    {
        public override BaseAddonDeed Deed => new AnvilEastDeed();


        [Constructible]
        public AnvilEastAddon()
        {
            AddComponent(new AnvilComponent(0xFAF), 0, 0, 0);
        }

        [Constructible]
        public AnvilEastAddon(Serial serial) : base(serial)
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

    public class AnvilEastDeed : BaseAddonDeed
    {
        public override BaseAddon Addon => new AnvilEastAddon();

        public override int LabelNumber => 1044333; // anvil (east)


        public AnvilEastDeed()
        {
        }

        public AnvilEastDeed(Serial serial) : base(serial)
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