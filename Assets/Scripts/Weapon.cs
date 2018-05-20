using System.Collections;
using System.Collections.Generic;
using FiringModes;
using UnityEngine;
using UnityEngine.Experimental.UIElements;


public class Weapon : MonoBehaviour
{

	private int currentAmmo;
	private int maxAmmo;

	private bool usable, inuse, unusable;

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
		firingMode = new SingleShot(this, 0.2f);
	}

	void Update()
	{
		if (Input.GetMouseButtonDown((int) MouseButton.LeftMouse))
		{
			WeaponPressed();
		}
	}
}
