namespace Server.Mobiles
{
    public class MerchantGuildmaster : BaseGuildmaster
	{
		public override NpcGuild NpcGuild{ get{ return NpcGuild.MerchantsGuild; } }


		[Constructible]
public MerchantGuildmaster() : base( "merchant" )
		{
			SetSkill( SkillName.ItemID, 85.0, 100.0 );
			SetSkill( SkillName.ArmsLore, 85.0, 100.0 );
		}

		[Constructible]
public MerchantGuildmaster( Serial serial ) : base( serial )
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
