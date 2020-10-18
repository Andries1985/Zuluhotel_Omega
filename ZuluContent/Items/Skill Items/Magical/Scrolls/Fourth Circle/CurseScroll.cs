namespace Server.Items
{
    public class CurseScroll : SpellScroll
    {
        [Constructible]
        public CurseScroll() : this(1)
        {
        }


        [Constructible]
        public CurseScroll(int amount) : base(Spells.SpellEntry.Curse, 0x1F47, amount)
        {
        }

        [Constructible]
        public CurseScroll(Serial serial) : base(serial)
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