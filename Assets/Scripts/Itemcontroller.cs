using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Itemcontroller : MonoBehaviour {

	public Transform[] Items;
	public bool Gotgun = false;
	public int Bullets = 30;
	public int CurrentItem;
	public AR shoot;
	public Text Guntext;
	public Text bulletText;




	// Use this for initialization
	void Start () {

		Guntext.text = "Unarmed";
		changeItem (0);
		SetBulletText ();
	}

	// Update is called once per frame
	void Update () {


		Invoke ("Fire", 0);


		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			changeItem (0);
			Guntext.text = "Unarmed";
		}
	    else if (Input.GetKeyDown (KeyCode.Alpha2)) {
			if (Gotgun == true) {
				changeItem (1);
				Guntext.text = "R23 A2";
			}
		}
	}
	void OnTriggerEnter (Collider other) {

		if (other.gameObject.CompareTag ("Gun")) {
			other.gameObject.SetActive (false);
			Gotgun = true;
			bulletText.text = Bullets.ToString ();
		}
		if (other.gameObject.CompareTag ("Magazine")) {
			other.gameObject.SetActive (false);
			Bullets += 30;
			bulletText.text = Bullets.ToString ();
		}

	}
	public void changeItem (int num){
		CurrentItem = num;
		for (int i = 0; i < 2; i++) {
			if (i == num)
				Items [i].gameObject.SetActive (true);
			else
				Items [i].gameObject.SetActive (false);


		} 
	}
	public void Fire (){

		if ( CurrentItem == 1) {
			if (Bullets >= 1) {
				if (Gotgun == true) {
					if (Input.GetKeyDown (KeyCode.Mouse0)) {
						shoot.Onfire ();
						Bullets -= 1;
						bulletText.text = Bullets.ToString ();
					}
				}
			}
		
		}

	} public void SetBulletText() {
		

	}
}





