using UnityEngine;
using System.Collections;

public class Pointer : MonoBehaviour {

	[SerializeField]
	private float gap;
	private Vector2 point;
	[SerializeField]
	private Camera camera;

	void Update ()
	{
		point = camera.ScreenToWorldPoint(Input.mousePosition);

		if (Input.GetButtonDown ("Fire1")) transform.position = new Vector3 (point.x+gap, point.y+gap, 0);
	}
}