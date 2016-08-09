using UnityEngine;
using System.Collections;

public class SpawnAsteroids : MonoBehaviour {

	private bool hazardActive;
	[SerializeField]
	private int asteroidsCount;
	[SerializeField]
	private float startTime;
	[SerializeField]
	private float waitTime;
	[SerializeField]
	private float hazardTime;
	[SerializeField]
	private Vector3 spawnValues;
	[SerializeField]
	private GameObject asteroid;

	void Start ()
	{
		hazardActive = true;
		StartCoroutine (HazardSpawn ());
	}

	public IEnumerator HazardSpawn()
	{
		yield return new WaitForSeconds (startTime);

		while (hazardActive == true)
		{
			for (int i = 0; i < asteroidsCount; i++)
			{
				Instantiate (asteroid, new Vector3 (Random.Range (-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z),transform.rotation);
				yield return new WaitForSeconds (waitTime);
			}
			yield return new WaitForSeconds (hazardTime);
			asteroidsCount++;
		}
	}
}