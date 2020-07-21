namespace Server.Items
{
    public class MeteorSwarmScroll : SpellScroll
	{

		[Constructible]
public MeteorSwarmScroll() : this( 1 )
		{
		}


		[Constructible]
public MeteorSwarmScroll( int amount ) : base( 54, 0x1F63, amount )
		{
		}

		[Constructible]
public MeteorSwarmScroll( Serial serial ) : base( serial )
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
