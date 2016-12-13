using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {

	public GameObject projectile;

	GameObject[] spawnPoints;
	int spawnIndex;
	float spawnTime = 0.5f;
	float timer;

	void Start () {
		spawnPoints = GameObject.FindGameObjectsWithTag ("Spawn Point");
		timer = spawnTime;
	}

	void Update () {
		timer -= Time.deltaTime;
		if (timer <= 0) {
			spawnIndex = Random.Range (0, spawnPoints.Length);
			Instantiate (projectile, spawnPoints [spawnIndex].transform.position, spawnPoints [spawnIndex].transform.rotation);
			timer = spawnTime;
		}
	}

}
