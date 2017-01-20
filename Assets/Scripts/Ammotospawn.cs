using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammotospawn : MonoBehaviour {

	public float Ammocountdelay = 30F;

	public int ammmotospawn = 0;

	public GameObject Shells;

	public GameObject Mags;

	public GameObject Nades;

	// Use this for initialization
	void Start () {
		
		ammmotospawn = Random.Range (1, 7);
		if (ammmotospawn == 1) {
			Instantiate (Mags, new Vector3 (transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
		}
		else if (ammmotospawn == 2) {
			Instantiate (Mags, new Vector3 (transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
		}
		else if (ammmotospawn == 3) {
			Instantiate (Mags, new Vector3 (transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
		}
		else if (ammmotospawn == 4) {
			return;
		}
		else if (ammmotospawn == 5) {
			Instantiate (Shells, new Vector3 (transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
		}
		else if (ammmotospawn == 6) {
			Instantiate (Shells, new Vector3 (transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
		}
		else if (ammmotospawn == 7) {
			Instantiate (Nades, new Vector3 (transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
		}
		InvokeRepeating ("Ammospawn", Ammocountdelay, Ammocountdelay);
	}
		// Update is called once per frame
	void Update () {
		
	
	}
	public void Ammospawn (){
		ammmotospawn = Random.Range (1, 7);
		if (ammmotospawn == 1) {
			Instantiate (Mags, new Vector3 (transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
		}
		else if (ammmotospawn == 2) {
			Instantiate (Mags, new Vector3 (transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
		}
		else if (ammmotospawn == 3) {
			Instantiate (Mags, new Vector3 (transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
		}
		else if (ammmotospawn == 4) {
			return;
		}
		else if (ammmotospawn == 5) {
			Instantiate (Shells, new Vector3 (transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
		}
		else if (ammmotospawn == 6) {
			Instantiate (Shells, new Vector3 (transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
		}
		else if (ammmotospawn == 7) {
			Instantiate (Nades, new Vector3 (transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
		}
	}

	}
