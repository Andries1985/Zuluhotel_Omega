using Server.Engines.Craft;

namespace Server.Items
{
    [FlipableAttribute( 0x0FBF, 0x0FC0 )]
	public class MapmakersPen : BaseTool
	{
		public override CraftSystem CraftSystem{ get{ return DefCartography.CraftSystem; } }

		public override int LabelNumber{ get{ return 1044167; } } // mapmaker's pen


		[Constructible]
public MapmakersPen() : base( 0x0FBF )
		{
			Weight = 1.0;
		}


		[Constructible]
public MapmakersPen( int uses ) : base( uses, 0x0FBF )
		{
			Weight = 1.0;
		}

		[Constructible]
public MapmakersPen( Serial serial ) : base( serial )
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

			if ( Weight == 2.0 )
				Weight = 1.0;
		}
	}
}
