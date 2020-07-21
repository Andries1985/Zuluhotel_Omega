namespace Server.Items
{
    public class Amber : Item
	{
		public override double DefaultWeight
		{
			get { return 0.1; }
		}


		[Constructible]
public Amber() : this( 1 )
		{
		}


		[Constructible]
public Amber( int amount ) : base( 0xF25 )
		{
			Stackable = true;
			Amount = amount;
		}

		[Constructible]
public Amber( Serial serial ) : base( serial )
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
