using UnityEngine;
using Weapons.Base;

namespace Weapons.WeaponTypes
{
    public class BaguetteWeapon : Weapon
    {
        public override void Attack()
        {
            Debug.Log("Crusty Wholesome Chop!");
        }
    }
}