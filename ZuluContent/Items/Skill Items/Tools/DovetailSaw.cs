using Server.Engines.Craft;

namespace Server.Items
{
    [Flipable( 0x1028, 0x1029 )]
	public class DovetailSaw : BaseTool
	{
		public override CraftSystem CraftSystem{ get{ return DefCarpentry.CraftSystem; } }


		[Constructible]
public DovetailSaw() : base( 0x1028 )
		{
			Weight = 2.0;
		}


		[Constructible]
public DovetailSaw( int uses ) : base( uses, 0x1028 )
		{
			Weight = 2.0;
		}

		[Constructible]
public DovetailSaw( Serial serial ) : base( serial )
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

			if ( Weight == 1.0 )
				Weight = 2.0;
		}
	}
}
