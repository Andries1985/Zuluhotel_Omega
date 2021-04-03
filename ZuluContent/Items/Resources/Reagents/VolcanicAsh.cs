namespace Server.Items
{
    public class VolcanicAsh : BaseReagent
    {
        public override string DefaultName { get; } = "Volcanic Ash";

        [Constructible]
        public VolcanicAsh() : this(1)
        {
        }


        [Constructible]
        public VolcanicAsh(int amount) : base(0xF8F, amount)
        {
        }

        [Constructible]
        public VolcanicAsh(Serial serial) : base(serial)
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