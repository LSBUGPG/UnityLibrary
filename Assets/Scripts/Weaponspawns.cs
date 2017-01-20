using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weaponspawns : MonoBehaviour {

	public int Weapontospawn = 0;
	public GameObject shotgun;
	public GameObject rifle;
	public GameObject Launcher;

	// Use this for initialization
	void Start () {

		Weapontospawn = Random.Range (1, 7);
		if (Weapontospawn == 1) {
			Instantiate (rifle, new Vector3 (transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
		}
		else if (Weapontospawn == 2) {
			Instantiate (rifle, new Vector3 (transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
		}
		else if (Weapontospawn == 3) {
			Instantiate (rifle, new Vector3 (transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
		}
		else if (Weapontospawn == 4) {
			return;
			}
		else if (Weapontospawn == 5) {
			Instantiate (shotgun, new Vector3 (transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
		}
		else if (Weapontospawn == 6) {
			Instantiate (shotgun, new Vector3 (transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
		}
		else if (Weapontospawn == 7) {
			Instantiate (Launcher, new Vector3 (transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
