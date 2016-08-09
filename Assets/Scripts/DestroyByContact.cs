using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour {

	//No funciona asi este la bala trigger

	public void OnTriggerEnter2D(Collider2D other)
	{
		Destroy (other.gameObject);
	}
}