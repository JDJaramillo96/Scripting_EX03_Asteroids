using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {

	[SerializeField]
	private float speed;
	private Rigidbody2D rigidBody;

	void Awake()
	{
		rigidBody = GetComponent<Rigidbody2D> ();
	}

	void Start ()
	{
		rigidBody.velocity = transform.up * speed;
	}
}