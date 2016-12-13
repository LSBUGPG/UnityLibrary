using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class Bullet : MonoBehaviour
{
	public float speed = 5f;
	Rigidbody rb;

	void Awake()
	{
		rb = GetComponent<Rigidbody>();
	}
	void Start()
	{
		rb.velocity = transform.right * speed;
	}

	void OnCollisionEnter(Collision Col){

		Debug.Log ("ive hit somthing");
		Destroy (gameObject);
	}
}
