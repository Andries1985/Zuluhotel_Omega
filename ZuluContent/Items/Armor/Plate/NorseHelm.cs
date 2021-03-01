using Server.Engines.Craft;

namespace Server.Items
{
    public class NorseHelm : BaseArmor, IFortifiable
    {
        public override int InitMinHits => 100;

        public override int InitMaxHits => 100;

        public override int DefaultStrReq => 40;

        public override int DefaultDexBonus => -3;

        public override double DefaultMagicEfficiencyPenalty => 7.0;

        public override int ArmorBase => 30;

        public override ArmorMaterialType MaterialType => ArmorMaterialType.Plate;


        [Constructible]
        public NorseHelm() : base(0x140E)
        {
            Weight = 5.0;
        }

        [Constructible]
        public NorseHelm(Serial serial) : base(serial)
        {
        }

        public override void Serialize(IGenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int) 0);
        }

        public override void Deserialize(IGenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();

            if (Weight == 1.0)
                Weight = 5.0;
        }
    }
}