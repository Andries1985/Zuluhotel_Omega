namespace Server.Items
{
    public class Amethyst : Item
	{
		public override double DefaultWeight
		{
			get { return 0.1; }
		}


		[Constructible]
public Amethyst() : this( 1 )
		{
		}


		[Constructible]
public Amethyst( int amount ) : base( 0xF16 )
		{
			Stackable = true;
			Amount = amount;
		}

		[Constructible]
public Amethyst( Serial serial ) : base( serial )
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
