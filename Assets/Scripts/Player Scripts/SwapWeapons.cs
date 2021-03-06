﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapWeapons : MonoBehaviour {

    public int selectedWeapon = 0;

	void Start ()
    {
        SelectWeapon();	
	}
	
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            selectedWeapon = 0;
            SelectWeapon();
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            selectedWeapon = 1;
            SelectWeapon();
        }
    }

    void SelectWeapon()
    {
        int i = 0;
        foreach (Transform weapon in transform)
        {
            if (i == selectedWeapon)
                weapon.gameObject.SetActive(true);
            else
                weapon.gameObject.SetActive(false);
            i++;
        }
    }
}
