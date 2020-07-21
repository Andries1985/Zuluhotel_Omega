namespace Server.Mobiles
{
    public class TailorGuildmaster : BaseGuildmaster
	{
		public override NpcGuild NpcGuild{ get{ return NpcGuild.TailorsGuild; } }


		[Constructible]
public TailorGuildmaster() : base( "tailor" )
		{
			SetSkill( SkillName.Tailoring, 90.0, 100.0 );
		}

		[Constructible]
public TailorGuildmaster( Serial serial ) : base( serial )
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
