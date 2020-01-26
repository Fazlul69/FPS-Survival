using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private WeaponManager weapon_Manager;

    public float fireRate = 15f;
    private float nextTimeToFire;
    public float damage = 20f;

    void Awake() {
        weapon_Manager = GetComponent<WeaponManager>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        WeaponShoot();
    }

    void WeaponShoot() {
        //if we have assult riffle
        if (weapon_Manager.GetCurrentSelectedWeapon().fireType == WeaponFireType.MULTIPLE)
        {
            //if we press and hold left mouse click AND
            //if time is greater then the nextTimeToFire
            if (Input.GetMouseButton(0) && Time.time > nextTimeToFire)
            {
                nextTimeToFire = Time.time + 1 / fireRate;

                weapon_Manager.GetCurrentSelectedWeapon().ShootAnimation();

                //BulletFired()
            }
        }
        else {

        }

    }//weaponshoot
}//class
