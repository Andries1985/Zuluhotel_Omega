using Server.Engines.Harvest;

namespace Server.Items
{
    public class SturdyShovel : BaseHarvestTool
	{
		public override int LabelNumber{ get{ return 1045125; } } // sturdy shovel
		public override HarvestSystem HarvestSystem{ get{ return Mining.System; } }


		[Constructible]
public SturdyShovel() : this( 180 )
		{
		}


		[Constructible]
public SturdyShovel( int uses ) : base( uses, 0xF39 )
		{
			Weight = 5.0;
			Hue = 0x973;
		}

		[Constructible]
public SturdyShovel( Serial serial ) : base( serial )
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
