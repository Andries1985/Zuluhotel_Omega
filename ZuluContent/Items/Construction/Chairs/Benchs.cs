namespace Server.Items
{
    [Furniture]
	[Flipable( 0xB2D, 0xB2C )]
	public class WoodenBench : Item
	{

		[Constructible]
public WoodenBench() : base( 0xB2D )
		{
			Weight = 6;
		}

		[Constructible]
public WoodenBench(Serial serial) : base(serial)
		{
		}

		public override void Serialize(IGenericWriter writer)
		{
			base.Serialize(writer);

			writer.Write((int) 0);
		}

		public override void Deserialize(IGenericReader reader)
		{
			base.Deserialize(reader);

			int version = reader.ReadInt();
		}
	}
}
