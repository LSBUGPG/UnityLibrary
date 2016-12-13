using UnityEngine;
using System.Collections;

public class SafeZone : MonoBehaviour {
	public GameObject player;
	void Start(){
		Physics.IgnoreCollision (gameObject.GetComponent<Collider> (), player.GetComponent<Collider> ());
	}

}
