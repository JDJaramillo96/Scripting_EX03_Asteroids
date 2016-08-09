using UnityEngine;
using System.Collections;

public class DestroyByTime : MonoBehaviour {

	public float waitTime;

	void Start ()
	{
		StartCoroutine (Destroy ());
	}

	IEnumerator Destroy()
	{
		yield return new WaitForSeconds (waitTime);
		Destroy (gameObject);
	}
}