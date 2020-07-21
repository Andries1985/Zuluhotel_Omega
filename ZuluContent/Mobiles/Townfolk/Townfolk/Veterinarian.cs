using System.Collections.Generic;

namespace Server.Mobiles
{
    public class Veterinarian : BaseVendor
	{
		private List<SBInfo> m_SBInfos = new List<SBInfo>();
		protected override List<SBInfo> SBInfos{ get { return m_SBInfos; } }


		[Constructible]
public Veterinarian() : base( "the vet" )
		{
			SetSkill( SkillName.AnimalLore, 85.0, 100.0 );
			SetSkill( SkillName.Veterinary, 90.0, 100.0 );
		}

		public override void InitSBInfo()
		{
			m_SBInfos.Add( new SBVeterinarian() );
		}

		[Constructible]
public Veterinarian( Serial serial ) : base( serial )
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
