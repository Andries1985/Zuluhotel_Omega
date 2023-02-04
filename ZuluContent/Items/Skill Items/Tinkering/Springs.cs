namespace Server.Items
{
    [Flipable( 0x105D, 0x105E )]
	public class Springs : BaseTinkerItem
	{

		[Constructible]
public Springs() : this( 1 )
		{
		}


		[Constructible]
public Springs( int amount ) : base( 0x105D )
		{
			Stackable = true;
			Amount = amount;
			Weight = 1.0;
		}

		[Constructible]
public Springs( Serial serial ) : base( serial )
		{
		}
		public override void Serialize( IGenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( IGenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}
