using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public GameObject c1;
	public GameObject c2;
	public GameObject cannon;
	public GameObject hazard;
	public Vector3 spawnValues;
	public int hazardCount;
	public float spawnWait;
	public float startWait;
	public float waveWait;

	// Use this for initialization
	void Start () {
		StartCoroutine (SpawnWaves ());
	}

	IEnumerator SpawnWaves ()
	{
		yield return new WaitForSeconds (startWait);
		while (true)
		{
			for (int i = 0; i < hazardCount; i++)
			{
				Vector3 spawnPosition = new Vector3 (120.0f, Random.Range (-36.0f, 36.0f),80.0f);
				Quaternion spawnRotation =  new Quaternion (0.5f, 0.5f, -0.5f, -0.5f);
				Instantiate (hazard, spawnPosition, spawnRotation);
				yield return new WaitForSeconds (spawnWait);
			}
			yield return new WaitForSeconds (waveWait);
		}
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetButton ("Fire1")) {
			Vector3 pos = c1.transform.position;
			Instantiate (cannon, pos,new Quaternion(0f,0f,0f,0f));
	
		}
	}
}
