using Server.Engines.Craft;

namespace Server.Items
{
    public class Inshave : BaseTool
	{
		public override CraftSystem CraftSystem{ get{ return DefCarpentry.CraftSystem; } }


		[Constructible]
public Inshave() : base( 0x10E6 )
		{
			Weight = 1.0;
		}


		[Constructible]
public Inshave( int uses ) : base( uses, 0x10E6 )
		{
			Weight = 1.0;
		}

		[Constructible]
public Inshave( Serial serial ) : base( serial )
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
