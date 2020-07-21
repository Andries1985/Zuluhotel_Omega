namespace Server.Items
{
    public class FarmableLettuce : FarmableCrop
	{
		public static int GetCropID()
		{
			return 3254;
		}

		public override Item GetCropObject()
		{
			Lettuce lettuce = new Lettuce();

			lettuce.ItemID = Utility.Random( 3184, 2 );

			return lettuce;
		}

		public override int GetPickedID()
		{
			return 3254;
		}


		[Constructible]
public FarmableLettuce() : base( GetCropID() )
		{
		}

		[Constructible]
public FarmableLettuce( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( IGenericWriter writer )
		{
			base.Serialize( writer );

			writer.WriteEncodedInt( 0 ); // version
		}

		public override void Deserialize( IGenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadEncodedInt();
		}
	}
}
