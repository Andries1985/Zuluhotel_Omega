using System;

namespace Server.Mobiles
{
    [Flags]
    public enum CreatureType
    {
        None = 0,
        Human,
        Undead,
        Elemental,
        Dragonkin,
        Animal,
        Daemon,
        Beholder,
        Animated,
        Slime,
        Terathan,
        Plant,
        Orc,
        Troll,
        Gargoyle,
        Ophidian,
        Ratkin,
        Giantkin
    }
}