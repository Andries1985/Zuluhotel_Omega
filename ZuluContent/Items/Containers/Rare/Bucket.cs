﻿namespace Server.Items
{
    class Bucket : BaseWaterContainer
    {
        public override int voidItem_ID
        {
            get { return vItemID; }
        }

        public override int fullItem_ID
        {
            get { return fItemID; }
        }

        public override int MaxQuantity
        {
            get { return 25; }
        }

        private static int vItemID = 0x14e0;
        private static int fItemID = 0x2004;


        [Constructible]
        public Bucket()
            : this(false)
        {
        }


        [Constructible]
        public Bucket(bool filled)
            : base(filled ? fItemID : vItemID, filled)
        {
        }

        [Constructible]
        public Bucket(Serial serial)
            : base(serial)
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
    }
}