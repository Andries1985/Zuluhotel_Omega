namespace Server.Items
{
    public class LargeForgeEastAddon : BaseAddon
    {
        public override BaseAddonDeed Deed => new LargeForgeEastDeed();


        [Constructible]
        public LargeForgeEastAddon()
        {
            AddComponent(new ForgeComponent(0x1986), 0, 0, 0);
            AddComponent(new ForgeComponent(0x198A), 0, 1, 0);
            AddComponent(new ForgeComponent(0x1996), 0, 2, 0);
            AddComponent(new ForgeComponent(0x1992), 0, 3, 0);
        }

        [Constructible]
        public LargeForgeEastAddon(Serial serial) : base(serial)
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

    public class LargeForgeEastDeed : BaseAddonDeed
    {
        public override BaseAddon Addon => new LargeForgeEastAddon();
        public override int LabelNumber => 1044331; // large forge (east)


        public LargeForgeEastDeed()
        {
        }

        public LargeForgeEastDeed(Serial serial) : base(serial)
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