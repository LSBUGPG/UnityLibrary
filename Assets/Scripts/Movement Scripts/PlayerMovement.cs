using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	private Transform ThisTransform = null;
	public float Speed;
	public float Rotation;
	// Use this for initialization
	void Start () {
		ThisTransform = GetComponent<Transform> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			ThisTransform.position += ThisTransform.forward * Speed;
		}
		if (Input.GetKeyDown(KeyCode.DownArrow)) {
			ThisTransform.position -= ThisTransform.forward * Speed;
		}
		if (Input.GetKeyDown(KeyCode.RightArrow)) {
			ThisTransform.Rotate (Vector3.up * Rotation);
		}
		if (Input.GetKeyDown(KeyCode.LeftArrow)) {
			ThisTransform.Rotate (Vector3.up * -Rotation);
		}

	}
}
