using UnityEngine;
using Weapons.Base;

namespace Weapons.WeaponTypes
{
    public class FeatherDusterWeapon : Weapon
    {
        public override void Attack()
        {
            Debug.Log("Tickle Tickle!");
        }
    }
}