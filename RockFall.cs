using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RockFall : MonoBehaviour {
	public GameObject[] myObjects;

	private bool Triggered = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	private void DestroyRocks(){
		foreach (GameObject objects in myObjects) {
			Destroy (objects);
		}
	}

	private void ReleaseRocks(){
		foreach (GameObject objects in myObjects){
			objects.GetComponent<Rigidbody> ().isKinematic = false;
			objects.GetComponent<Rigidbody> ().useGravity = true;
		}
		Invoke ("DestroyRocks", 10);
	}
		

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Player" && Triggered == false) {
			Triggered = true;
			ReleaseRocks();
		}
	}

}
