namespace Server.Items
{
    public class Ruby : Item
	{
		public override double DefaultWeight
		{
			get { return 0.1; }
		}


		[Constructible]
public Ruby() : this( 1 )
		{
		}


		[Constructible]
public Ruby( int amount ) : base( 0xF13 )
		{
			Stackable = true;
			Amount = amount;
		}

		[Constructible]
public Ruby( Serial serial ) : base( serial )
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
