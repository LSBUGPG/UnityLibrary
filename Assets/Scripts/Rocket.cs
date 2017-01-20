using UnityEngine;
using System.Collections;

public class Rocket : MonoBehaviour {

	public float speed = 20.0f;
	public float life = 5.0f;
	public float damageDealt;

	// Use this for initialization
	void Start () {
	
		Invoke ("Kill", life);
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.position += transform.forward * speed * Time.deltaTime;
	}

	//Destory gameobject when Kill is called
	void Kill()
	{
		Destroy (gameObject);
	}
}
