namespace Server.Items
{
    public class LesserExplosionPotion : BaseExplosionPotion
	{
		public override int MinDamage { get { return 5; } }
		public override int MaxDamage { get { return 10; } }


		[Constructible]
public LesserExplosionPotion() : base( PotionEffect.ExplosionLesser )
		{
		}

		[Constructible]
public LesserExplosionPotion( Serial serial ) : base( serial )
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
