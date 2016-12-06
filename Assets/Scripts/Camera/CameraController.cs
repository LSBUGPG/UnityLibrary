using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public Camera[] cameras;

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
	
		if (Input.GetKeyDown(KeyCode.Q)) {
			
			cameras [0].gameObject.SetActive (!cameras [0].gameObject.activeSelf);
			cameras [1].gameObject.SetActive (!cameras [1].gameObject.activeSelf);
		}
	}
}