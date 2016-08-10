using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	private Score score;

	void Awake()
	{
		score = GameObject.Find ("GameController").GetComponent<Score> ();
	}

	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject == GameObject.Find ("Asteroid(Clone)")) score.UpdateScore ();
	}
}