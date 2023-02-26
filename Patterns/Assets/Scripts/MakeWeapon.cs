using Weapons.Enumerations;
using Weapons.Factories;
using UnityEngine;

public class MakeWeapon : MonoBehaviour
{
    public void Start()
    {
        var weaponFactory = new WeaponFactory();

        var chosenWeapon = weaponFactory.CreateWeapon(WeaponType.Baguette);
        chosenWeapon.Attack();
    }
}