using UnityEngine;
using System.Collections;

public class PlayerMov : MonoBehaviour {
	public float Speed = 5f;
	public float RotSpeed = 90f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey(KeyCode.UpArrow)) {
			transform.position += transform.forward * Speed * Time.deltaTime ;
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Rotate (Vector3.up * RotSpeed * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Rotate (Vector3.up * -RotSpeed * Time.deltaTime);
		}
	}
}
