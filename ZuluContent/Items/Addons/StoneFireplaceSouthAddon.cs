namespace Server.Items
{
    public class StoneFireplaceSouthAddon : BaseAddon
	{
		public override BaseAddonDeed Deed{ get{ return new StoneFireplaceSouthDeed(); } }


		[Constructible]
public StoneFireplaceSouthAddon()
		{
			AddComponent( new AddonComponent( 0x967 ), -1, 0, 0 );
			AddComponent( new AddonComponent( 0x961 ), 0, 0, 0 );
		}

		[Constructible]
public StoneFireplaceSouthAddon( Serial serial ) : base( serial )
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

	public class StoneFireplaceSouthDeed : BaseAddonDeed
	{
		public override BaseAddon Addon{ get{ return new StoneFireplaceSouthAddon(); } }
		public override int LabelNumber{ get{ return 1061849; } } // stone fireplace (south)


		public StoneFireplaceSouthDeed()
		{
		}

		public StoneFireplaceSouthDeed( Serial serial ) : base( serial )
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
