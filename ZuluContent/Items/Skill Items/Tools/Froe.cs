using Server.Engines.Craft;

namespace Server.Items
{
    public class Froe : BaseTool
	{
		public override CraftSystem CraftSystem{ get{ return DefCarpentry.CraftSystem; } }


		[Constructible]
public Froe() : base( 0x10E5 )
		{
			Weight = 1.0;
		}


		[Constructible]
public Froe( int uses ) : base( uses, 0x10E5 )
		{
			Weight = 1.0;
		}

		[Constructible]
public Froe( Serial serial ) : base( serial )
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
