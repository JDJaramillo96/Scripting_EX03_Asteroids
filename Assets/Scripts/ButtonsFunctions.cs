using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonsFunctions : MonoBehaviour {

	private bool menuActive;
	[SerializeField]
	private GameObject menu;

	void Start ()
	{
		menuActive = true;
	}

	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.P)) menuActive = !menuActive;

		if (menuActive = true)
		{
			menu.SetActive (true);
			Time.timeScale = 0f;
		}

		if (menuActive = false)
		{
			menu.SetActive (false);
			Time.timeScale = 1f;
		}
	}

	public void Play()
	{
		menuActive = false;
	}

	public void Restart()
	{
		SceneManager.LoadScene (0);
	}

	public void Exit()
	{
		Application.Quit ();
	}
}