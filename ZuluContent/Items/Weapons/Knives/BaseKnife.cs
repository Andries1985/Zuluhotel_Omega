using Server.Targets;

namespace Server.Items
{
    public abstract class BaseKnife : BaseMeleeWeapon
    {
        public override int DefaultHitSound => 0x23B;
        public override int DefaultMissSound => 0x239;

        public override SkillName DefaultSkill => SkillName.Fencing;

        public override WeaponType DefaultWeaponType => WeaponType.Slashing;

        public override WeaponAnimation DefaultAnimation => WeaponAnimation.Pierce1H;

        public BaseKnife(int itemID) : base(itemID)
        {
        }

        public BaseKnife(Serial serial) : base(serial)
        {
        }

        public override void Serialize(IGenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int) 0); // version
        }

        public override void Deserialize(IGenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }

        public override void OnDoubleClick(Mobile from)
        {
            from.SendLocalizedMessage(1010018); // What do you want to use this item on?

            from.Target = new BladedItemTarget(this);
        }
    }
}