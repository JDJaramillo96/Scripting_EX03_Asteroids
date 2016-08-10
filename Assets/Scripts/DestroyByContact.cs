using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DestroyByContact : MonoBehaviour {

	private GameObject menu;
	private GameObject restart;

	void Awake()
	{
		menu = GameObject.Find ("Canvas");
		restart = menu.transform.FindChild ("Restart").gameObject;
	}

	void OnCollisionEnter2D (Collision2D coll) 
	{
		if (coll.gameObject == GameObject.Find ("Galaga"))
		{
			Destroy (gameObject);
			Destroy (coll.gameObject);
			restart.SetActive (true);
		}
		else
		{
			Destroy (gameObject);
			Destroy (coll.gameObject);
		}
	}
}