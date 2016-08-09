using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

	[SerializeField]
	private GameObject bullet;
	[SerializeField]
	private Transform bulletSpawn;

	void Update ()
	{
		if (Input.GetButtonDown ("Shoot")) Instantiate (bullet, bulletSpawn.position, bulletSpawn.rotation);
	}
}