using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	private int points;
	[SerializeField]
	private Text scoreText;

	void Start()
	{
		points = 0;
	}

	void Update ()
	{
		scoreText.text = "Score: " + points.ToString ();
	}

	public void UpdateScore()
	{
		points++;
	}
}