using UnityEngine;
using System.Collections;

public class AR : MonoBehaviour {

	public GameObject Prefab;
	Itemcontroller fire;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


	
	}

	public void Onfire(){
		GameObject bullet = Instantiate (Prefab, new Vector3 (transform.position.x, transform.position.y, transform.position.z), Quaternion.identity) as GameObject;
		Rigidbody rb = bullet.GetComponent<Rigidbody> ();
		rb.velocity = Camera.main.transform.forward * 40;
	}
}
