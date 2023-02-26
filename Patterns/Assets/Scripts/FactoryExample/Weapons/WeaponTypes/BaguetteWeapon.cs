using FactoryExample.Weapons.Base;
using UnityEngine;

namespace FactoryExample.Weapons.WeaponTypes
{
    public class BaguetteWeapon : Weapon
    {
        public override void Attack()
        {
            Debug.Log("Crusty Wholesome Chop!");
        }
    }
}