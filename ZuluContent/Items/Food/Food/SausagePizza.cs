namespace Server.Items
{
    public class SausagePizza : Food
    {
        public override int LabelNumber{ get{ return 1044517; } } // sausage pizza


        [Constructible]
public SausagePizza() : base( 0x1040 )
        {
            Stackable = false;
            Weight = 1.0;
            FillFactor = 6;
        }

        [Constructible]
public SausagePizza( Serial serial ) : base( serial )
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
