using System;
using FactoryExample.Weapons.Base;
using FactoryExample.Weapons.Enumerations;
using FactoryExample.Weapons.WeaponTypes;

namespace FactoryExample.Weapons.Factories
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