using Server.Engines.Craft;

namespace Server.Items
{
    [FlipableAttribute( 0x1034, 0x1035 )]
	public class Saw : BaseTool
	{
		public override CraftSystem CraftSystem{ get{ return DefCarpentry.CraftSystem; } }


		[Constructible]
public Saw() : base( 0x1034 )
		{
			Weight = 2.0;
		}


		[Constructible]
public Saw( int uses ) : base( uses, 0x1034 )
		{
			Weight = 2.0;
		}

		[Constructible]
public Saw( Serial serial ) : base( serial )
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
