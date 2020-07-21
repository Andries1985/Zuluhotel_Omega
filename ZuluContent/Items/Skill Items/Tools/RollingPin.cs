using Server.Engines.Craft;

namespace Server.Items
{
    public class RollingPin : BaseTool
	{
		public override CraftSystem CraftSystem{ get{ return DefCooking.CraftSystem; } }


		[Constructible]
public RollingPin() : base( 0x1043 )
		{
			Weight = 1.0;
		}


		[Constructible]
public RollingPin( int uses ) : base( uses, 0x1043 )
		{
			Weight = 1.0;
		}

		[Constructible]
public RollingPin( Serial serial ) : base( serial )
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
