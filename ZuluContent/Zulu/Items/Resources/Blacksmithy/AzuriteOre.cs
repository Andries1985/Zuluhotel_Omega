// Generated File. DO NOT MODIFY BY HAND.

namespace Server.Items
{
    public class AzuriteOre : BaseOre
    {
        [Constructible]
        public AzuriteOre() : this(1)
        {
        }


        [Constructible]
        public AzuriteOre(int amount) : base(CraftResource.Azurite, amount)
        {
        }

        [Constructible]
        public AzuriteOre(Serial serial) : base(serial)
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

        public override BaseIngot GetIngot()
        {
            return new AzuriteIngot();
        }
    }
}