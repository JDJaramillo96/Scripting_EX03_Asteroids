using UnityEngine;
using System.Collections;

public class DestroyByPosition : MonoBehaviour {

	[SerializeField]
	private float yLimit;

	void Update ()
	{
		if (gameObject.transform.position.y <= yLimit) Destroy (gameObject);
	}
}