using System.Collections.Generic;

namespace Server.Mobiles
{
    public class Bard : BaseVendor
	{
		private List<SBInfo> m_SBInfos = new List<SBInfo>();
		protected override List<SBInfo> SBInfos{ get { return m_SBInfos; } }

		public override NpcGuild NpcGuild{ get{ return NpcGuild.BardsGuild; } }


		[Constructible]
public Bard() : base( "the bard" )
		{
			SetSkill( SkillName.Discordance, 64.0, 100.0 );
			SetSkill( SkillName.Musicianship, 64.0, 100.0 );
			SetSkill( SkillName.Peacemaking, 65.0, 88.0 );
			SetSkill( SkillName.Provocation, 60.0, 83.0 );
			SetSkill( SkillName.Archery, 36.0, 68.0 );
			SetSkill( SkillName.Swords, 36.0, 68.0 );
		}

		public override void InitSBInfo()
		{
			m_SBInfos.Add( new SBBard() );
		}

		[Constructible]
public Bard( Serial serial ) : base( serial )
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
