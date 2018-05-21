using System.Collections;
using System.Collections.Generic;
using FiringModes;
using UnityEngine;
using UnityEngine.Experimental.UIElements;


public class Weapon : MonoBehaviour
{

	private int currentAmmo;
	private int maxAmmo;

	private float multiplier;

	private Ammunition ammoType;
	private IFiringMode firingMode;

	public void Shoot()
	{
		Debug.Log("Bang!");
	}

	public void WeaponPressed()
	{
		firingMode.FirePressed();
	}

	public void WeaponDown()
	{
		firingMode.FireDown();
	}

	public void WeaponReleased()
	{
		firingMode.FireReleased();
	}

	void Start()
	{
		firingMode = gameObject.AddComponent<FMCharge>().FMChargeInit(this, 1f, false, false);
		
	}

	void Update()
	{
		if (Input.GetMouseButtonDown((int) MouseButton.LeftMouse))
		{
			WeaponPressed();
		}
		if (Input.GetMouseButton((int) MouseButton.LeftMouse))
		{
			WeaponDown();
		}
		if (Input.GetMouseButtonUp((int) MouseButton.LeftMouse))
		{
			WeaponReleased();
		}
	}
}
