using UnityEngine;
using System.Collections;

public class RandomProjectiles : MonoBehaviour {

	public float timer = 0f;
	public float timePassing = 1f;
	public GameObject prefab;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		timer += timePassing;
		if (timer == 30f) {
			timer = 0;
			GameObject obj = (GameObject)Instantiate(prefab,new Vector3(Random.Range(1,20),Random.Range(1,20),Random.Range(1,20)),Quaternion.identity);
		}
	
	}
}
