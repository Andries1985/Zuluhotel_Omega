using System.Collections.Generic;

namespace Server.Mobiles
{
    public class InnKeeper : BaseVendor
	{
		private List<SBInfo> m_SBInfos = new List<SBInfo>();
		protected override List<SBInfo> SBInfos{ get { return m_SBInfos; } }


		[Constructible]
public InnKeeper() : base( "the innkeeper" )
		{
		}

		public override void InitSBInfo()
		{
			m_SBInfos.Add( new SBInnKeeper() );
		}

		public override VendorShoeType ShoeType
		{
			get{ return Utility.RandomBool() ? VendorShoeType.Sandals : VendorShoeType.Shoes; }
		}

		[Constructible]
public InnKeeper( Serial serial ) : base( serial )
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
