namespace Server.Items
{
    public abstract class BaseRefreshPotion : BasePotion
	{
		public abstract double Refresh{ get; }

		public BaseRefreshPotion( PotionEffect effect ) : base( 0xF0B, effect )
		{
		}

		public BaseRefreshPotion( Serial serial ) : base( serial )
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

		public override void Drink( Mobile from )
		{
			if ( from.Stam < from.StamMax )
            {
                if (PotionStrength > 3)
                {
                    from.Stam = from.StamMax;
                }
                else
                {
                    var mod = Utility.Dice(5, 5, 5) * (int)PotionStrength;
                    from.Stam += mod;
                }

                PlayDrinkEffect( from );
                Consume();
			}
			else
			{
				from.SendMessage( "You decide against drinking this potion, as you are already at full stamina." );
			}
		}
	}
}
