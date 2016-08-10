using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ButtonsFunctions : MonoBehaviour {

	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.R)) SceneManager.LoadScene ("Main");
	}
}