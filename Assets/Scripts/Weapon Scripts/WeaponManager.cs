using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    [SerializeField] private WeaponHandler[] weapons;

    private int current_Weapon_Index;

    // Start is called before the first frame update
    void Start()
    {
        current_Weapon_Index = 0;
        weapons[current_Weapon_Index].gameObject.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) {
            TurnOnSelectionWeapon(0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            TurnOnSelectionWeapon(1);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            TurnOnSelectionWeapon(2);
        }
       
    }

    void TurnOnSelectionWeapon(int weaponIndex)
    {
        //turn of the current weappon
        weapons[current_Weapon_Index].gameObject.SetActive(false);

        // turn on the selected weappon
        weapons[weaponIndex].gameObject.SetActive(true);

        current_Weapon_Index = weaponIndex;
    }

    public WeaponHandler GetCurrentSelectedWeapon() {
        return weapons[current_Weapon_Index];
    }
}