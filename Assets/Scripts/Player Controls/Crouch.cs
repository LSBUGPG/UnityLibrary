using UnityEngine;
using System.Collections;

public class Crouch : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
	
		if (Input.GetKey (KeyCode.C)) {
			transform.localScale = new Vector3 (0.5f, 0.5f, 0.5f);

		} else {
			transform.localScale = new Vector3 (1f, 1f, 1f);

		}
	}
}

