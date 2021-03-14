using System;
using Scripts.Zulu.Packets;
using Server.Network;
using Server.Spells;
using ZuluContent.Zulu.Engines.Magic.Enchantments.Buffs;

namespace Server.Items
{
    public abstract class BaseMagicFish : Item
    {
        public virtual int Bonus { get; } = 0;

        public virtual StatType Type { get; } = StatType.Str;

        public override double DefaultWeight { get; } = 1.0;

        public BaseMagicFish(int hue) : base(0xDD6)
        {
            Hue = hue;
        }

        public BaseMagicFish(Serial serial) : base(serial)
        {
        }

        public virtual bool Apply(Mobile from)
        {
            var applied = from.TryAddBuff(new StatBuff(Type)
            {
                Title = LabelNumber > 0 ? ClilocList.Translate(LabelNumber, string.Empty, true) : null,
                Value = Bonus,
                Duration = TimeSpan.FromMinutes(1.0),
                Details = new[] {"Mmm... fishy."},
                Dispellable = false,
                ExpireOnDeath = false
            });

            if (!applied)
                from.SendLocalizedMessage(502173); // You are already under a similar effect.

            return applied;
        }

        public override void OnDoubleClick(Mobile from)
        {
            if (!IsChildOf(from.Backpack))
            {
                from.SendLocalizedMessage(1042001); // That must be in your pack for you to use it.
            }
            else if (Apply(from))
            {
                from.FixedEffect(0x375A, 10, 15);
                from.PlaySound(0x1E7);
                from.LocalOverheadMessage(MessageType.Regular, 0x3B2, 501774); // You swallow the fish whole!
                Delete();
            }
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

    public class PrizedFish : BaseMagicFish
    {
        public override int Bonus { get; } = 5;

        public override StatType Type { get; } = StatType.Int;

        public override int LabelNumber { get; } = 1041073; // prized fish


        [Constructible]
        public PrizedFish() : base(51)
        {
        }

        [Constructible]
        public PrizedFish(Serial serial) : base(serial)
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

            if (Hue == 151)
                Hue = 51;
        }
    }

    public class WondrousFish : BaseMagicFish
    {
        public override int Bonus { get; } = 5;

        public override StatType Type { get; } = StatType.Dex;

        public override int LabelNumber { get; } = 1041074; // wondrous fish


        [Constructible]
        public WondrousFish() : base(86)
        {
        }

        [Constructible]
        public WondrousFish(Serial serial) : base(serial)
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

            if (Hue == 286)
                Hue = 86;
        }
    }

    public class TrulyRareFish : BaseMagicFish
    {
        public override int Bonus { get; } = 5;

        public override StatType Type { get; } = StatType.Str;

        public override int LabelNumber { get; } = 1041075; // truly rare fish


        [Constructible]
        public TrulyRareFish() : base(76)
        {
        }

        [Constructible]
        public TrulyRareFish(Serial serial) : base(serial)
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

            if (Hue == 376)
                Hue = 76;
        }
    }

    public class PeculiarFish : BaseMagicFish
    {
        public override int LabelNumber { get; } = 1041076; // highly peculiar fish


        [Constructible]
        public PeculiarFish() : base(66)
        {
        }

        [Constructible]
        public PeculiarFish(Serial serial) : base(serial)
        {
        }

        public override bool Apply(Mobile from)
        {
            from.Stam += 10;
            return true;
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

            if (Hue == 266)
                Hue = 66;
        }
    }
}