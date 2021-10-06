using System;
using Server.Items;
using Server.Spells;
using Server.Spells.Sixth;

namespace Server.Engines.Magic.HitScripts
{
    public class PiercingStrike : WeaponAbility
    {
        public override void OnHit(Mobile attacker, Mobile defender, ref int damage)
        {
            if (!Validate(attacker))
                return;
            
            // Kinda hacky, basically set the weapons damage to 0 and deal raw damage ourselves
            if (attacker.Weapon != attacker.GetDefaultWeapon() && attacker.Weapon is BaseWeapon weapon)
            {
                defender.Damage((int) weapon.ScaleDamage(attacker, defender, damage, weapon, piercing: true), attacker);
                damage = 0;
            }
        }
    }
}