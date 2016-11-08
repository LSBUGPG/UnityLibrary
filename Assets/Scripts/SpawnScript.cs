using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {

	public GameObject asteroid;

	GameObject[] spawnPoints;
	int spawnIndex;
	float spawnTime = 1;
	float timer;
	// Use this for initialization
	void Start () {
		spawnPoints = GameObject.FindGameObjectsWithTag ("Spawn Point");
		timer = spawnTime;
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		if (timer <= 0) {
			spawnIndex = Random.Range (0, spawnPoints.Length);
			Instantiate (asteroid, spawnPoints [spawnIndex].transform.position, spawnPoints [spawnIndex].transform.rotation);
			timer = spawnTime;
		}
	}

}
