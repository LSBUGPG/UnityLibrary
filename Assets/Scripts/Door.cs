using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {

	public GameObject DoorOpen;
	public bool doorIsOpening;
	public GameObject hinge;
	private Animator hingeAnim;
	public GameObject button;
	//public MovingPlatform Platform;

	// Use this for initialization
	void Start () {
		hingeAnim = hinge.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {


		if (Input.GetKeyDown(KeyCode.E)) 
		{
			float dist = Mathf.Abs(transform.position.x-button.transform.position.x);
			if (dist < 1.3f) 
			{
				hingeAnim.SetTrigger ("DoorOpen");
				doorIsOpening = true;
				//Platform.PlatformMove ();
			}
		}
	}
}
