using FactoryExample.Weapons.Base;
using UnityEngine;

namespace FactoryExample.Weapons.WeaponTypes
{
    public class FeatherDusterWeapon : Weapon
    {
        public override void Attack()
        {
            Debug.Log("Tickle Tickle!");
        }
    }
}