using FactoryExample.Weapons.Enumerations;
using FactoryExample.Weapons.Factories;
using UnityEngine;

namespace FactoryExample
{
    public class CreateWeaponToAttack : MonoBehaviour
    {
        [SerializeField] private WeaponType weaponAttackType;
        public void Start()
        {
            var weaponFactory = new WeaponFactory();

            var chosenWeapon = weaponFactory.CreateWeapon(weaponAttackType);
            chosenWeapon.Attack();
        }
    }
}