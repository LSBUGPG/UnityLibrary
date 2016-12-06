using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	public float speed = 3f;

	// Use this for initialization
	void Start () {

	
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.position += transform.forward * speed * Time.deltaTime;
	
	}
	void OnCollisionEnter(Collision Col){

	Debug.Log ("ive hit somthing");
	Destroy (gameObject);
}
}
