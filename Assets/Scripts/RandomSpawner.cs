using UnityEngine;
using System.Collections;

public class RandomSpawner : MonoBehaviour {

	public GameObject[] spawningObjects; //Array of all objects that should/could be spawned. -Tobias Persson
	public Vector3 minSpawn; //The minimum position in world space that an object will be able to be spawned in. -Tobias Persson
	public Vector3 maxSpawn; //The maximum position in world space that an object will be able to be spawned in. -Tobias Persson

	Vector3 randomSpawn; //The randomized position a object will spawn at. -Tobias Persson
	float randomPosX;
	float randomPosY;
	float randomPosZ;

	float randomIndex; //a randomized index in the gameobject array. -Tobias Persson
	// Use this for initialization
	void Start () {
		Spawn (0, new Vector3 (0, 0, 0)); //Spawns the first object in an array in the middle of the world. -Tobias Persson
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space)) { //When space is pressed. It picks a random index between 0 and the maximum of the array. It randomizes the position and spawns an object there. -Tobias Persson
			randomIndex = Random.Range (0, spawningObjects.Length);
			RandomizePosition ();
			SpawnRandom (0);
		}
	}

	public void RandomizePosition(){ //Function to randomize a position.
		randomPosX = Random.Range (minSpawn.x, maxSpawn.x);
		randomPosY = Random.Range (minSpawn.y, maxSpawn.y);
		randomPosZ = Random.Range (minSpawn.z, maxSpawn.z);
	}

	//Functions to spawn object in determined position. There are two depending on what information you want to give when spawning an object. -Tobias Persson
	public void Spawn(int Index, Vector3 Position){
		Instantiate (spawningObjects [Index], Position, Quaternion.identity);
	}
	public void Spawn(int Index, Vector3 Position, Quaternion Rotation){
		Instantiate (spawningObjects [Index], Position, Rotation);
	}

	//Functions to spawn object in a random position. There are two depending on what information you want to give when spawning an object. -Tobias Persson
	public void SpawnRandom(int Index){
		randomSpawn = new Vector3 (randomPosX, randomPosY, randomPosZ);
		Instantiate (spawningObjects [Index],randomSpawn, Quaternion.identity);
	}
	public void SpawnRandom(int Index, Quaternion Rotation){
		randomSpawn = new Vector3 (randomPosX, randomPosY, randomPosZ);
		Instantiate (spawningObjects [Index],randomSpawn, Rotation);
	}
}
