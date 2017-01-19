using UnityEngine;
using System.Collections;

public class RocketLauncher : MonoBehaviour {

	public GameObject rocketPrefab;
	public Transform rocketBarrel;
	public float reloadTime = 1.0f;

	private float lastFireTime;

	// Use this for initialization
	void Start () {
	
	}

	void Update () {
		if (Input.GetButtonDown("Fire1") && Time.time > lastFireTime + reloadTime) 
		{
			GameObject go = (GameObject)Instantiate(rocketPrefab, rocketBarrel.position, Quaternion.LookRotation (rocketBarrel.forward));
			Physics.IgnoreCollision (GetComponent<Collider> (), go.GetComponent<Collider> ());
			lastFireTime = Time.time;
		}
	
	}
}
