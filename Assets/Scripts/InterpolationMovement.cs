using UnityEngine;
using System.Collections;

public class InterpolationMovement : MonoBehaviour {

	[SerializeField]
	private float speed;
	private Vector3 point;
	[SerializeField]
	private Camera camera;

	void Update ()
	{
		point = camera.ScreenToWorldPoint(Input.mousePosition);

		if (Input.GetButton ("Fire2") && Input.GetAxis ("Vertical") == 0) ChangePosition ();
	}

	public void ChangePosition()
	{
		transform.position = Vector3.Lerp (transform.position, new Vector3 (point.x, point.y, 0), Time.deltaTime * speed);
	}
}