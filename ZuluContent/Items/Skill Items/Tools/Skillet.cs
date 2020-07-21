using Server.Engines.Craft;

namespace Server.Items
{
    public class Skillet : BaseTool
	{
		public override int LabelNumber{ get{ return 1044567; } } // skillet

		public override CraftSystem CraftSystem{ get{ return DefCooking.CraftSystem; } }


		[Constructible]
public Skillet() : base( 0x97F )
		{
			Weight = 1.0;
		}


		[Constructible]
public Skillet( int uses ) : base( uses, 0x97F )
		{
			Weight = 1.0;
		}

		[Constructible]
public Skillet( Serial serial ) : base( serial )
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
