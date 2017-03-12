using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackAnim : MonoBehaviour {

	public GameObject TestStick;
	public GameObject weaponplaceholder1;
	public GameObject weaponplaceholder2;
	public int currentitem;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			currentitem = 0;
			}
		if (Input.GetKeyDown (KeyCode.Alpha2)) {
			currentitem = 1;
		}
		if (Input.GetKeyDown (KeyCode.Alpha3)) {
			currentitem = 2;
		}

		if (Input.GetKeyDown (KeyCode.Mouse0)) {
			if (currentitem == 0) {
				TestStick.gameObject.SetActive (true);
				Invoke ("Clearweapon", 1);
			}
			if (Input.GetKeyDown (KeyCode.Mouse0)) {
				if (currentitem == 1) {
					weaponplaceholder1.SetActive (true);
					Invoke ("Clearweapon", 1);
				}
				if (Input.GetKeyDown (KeyCode.Mouse0)) {
					if (currentitem == 2) {
						weaponplaceholder2.SetActive (true);
						Invoke ("Clearweapon", 1);
					}

				}
					
			}
		}
	}
	void Clearweapon () {
	TestStick.gameObject.SetActive (false);
	weaponplaceholder1.SetActive (false);
	weaponplaceholder2.SetActive (false);
	}
}
