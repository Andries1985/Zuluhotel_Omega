using System.Collections.Generic;

namespace Server.Mobiles
{
    public class Baker : BaseVendor
	{
		private List<SBInfo> m_SBInfos = new List<SBInfo>();
		protected override List<SBInfo> SBInfos{ get { return m_SBInfos; } }


		[Constructible]
public Baker() : base( "the baker" )
		{
			SetSkill( SkillName.Cooking, 75.0, 98.0 );
			SetSkill( SkillName.TasteID, 36.0, 68.0 );
		}

		public override void InitSBInfo()
		{
			m_SBInfos.Add( new SBBaker() );
		}

		[Constructible]
public Baker( Serial serial ) : base( serial )
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
