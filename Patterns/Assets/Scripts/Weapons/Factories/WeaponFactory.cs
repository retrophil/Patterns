using System;
using Weapons.Base;
using Weapons.Enumerations;
using Weapons.WeaponTypes;

namespace Weapons.Factories
{
    public class WeaponFactory
    {
        public Weapon CreateWeapon(WeaponType type) =>
            type switch
            {
                WeaponType.Baguette => new BaguetteWeapon(),
                WeaponType.FeatherDuster => new FeatherDusterWeapon(),
                _ => throw new ArgumentException("Invalid weapon type")
            };
    }
}