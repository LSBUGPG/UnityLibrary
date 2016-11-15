using UnityEngine;
using System.Collections;

public class InTheZone : MonoBehaviour {

	public Animator anim;
	public GameObject player; 
	public int ZonedIn = 0;

	// Use this for initialization
	void Start () {
		

	}
	
	// Update is called once per frame
	void Update () {

		ZonedIn -= 1;

		if (ZonedIn <= 0) {

			ZonedIn = 0;
		
				
		}
		if (ZonedIn >= 1) {
			
			anim.SetInteger ("In", 1);
	
		}
		else if (ZonedIn <= 0) {
			anim.SetInteger ("In", 0);
		}
	}

	public void OnTriggerStay(Collider other){

		if (other.name == "player") {

			ZonedIn = 10;

			
		}
	

}
}


