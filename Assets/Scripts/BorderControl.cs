using UnityEngine;
using System.Collections;

public class BorderControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void OnTriggerEnter (Collider other) {
		print ("Hitmonlee");
		if (other.gameObject.tag == "Projectile") {
			Destroy (other.gameObject);
		}
	}
}
