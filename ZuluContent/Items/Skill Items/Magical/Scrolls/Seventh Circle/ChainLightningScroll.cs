namespace Server.Items
{
    public class ChainLightningScroll : SpellScroll
    {
        [Constructible]
        public ChainLightningScroll() : this(1)
        {
        }


        [Constructible]
        public ChainLightningScroll(int amount) : base(Spells.SpellEntry.ChainLightning, 0x1F5D, amount)
        {
        }

        [Constructible]
        public ChainLightningScroll(Serial serial) : base(serial)
        {
        }

        public override void Serialize(IGenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write(0); // version
        }

        public override void Deserialize(IGenericReader reader)
        {
            base.Deserialize(reader);

            var version = reader.ReadInt();
        }
    }
}