namespace Server.Items
{
    public class FarmableCabbage : FarmableCrop
	{
		public static int GetCropID()
		{
			return 3254;
		}

		public override Item GetCropObject()
		{
			Cabbage cabbage = new Cabbage();

			cabbage.ItemID = Utility.Random( 3195, 2 );

			return cabbage;
		}

		public override int GetPickedID()
		{
			return 3254;
		}


		[Constructible]
public FarmableCabbage() : base( GetCropID() )
		{
		}

		[Constructible]
public FarmableCabbage( Serial serial ) : base( serial )
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
