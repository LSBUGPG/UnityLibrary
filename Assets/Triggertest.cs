using UnityEngine;
using System.Collections;

public class Triggertest : MonoBehaviour {

	public int Vision = 0;
	public GameObject Player;

	// Use this for initialization
	void Awake () {
	}

	// Update is called once per frame
	void Update () {

		Vision -= 10;
		if (Vision <= 1) {

		}
		if (Vision <= 0) {
			Vision = 0;
		}
	}
	void OnTriggerStay(Collider other)
	{
		if (other.name == "Player") {
			Vision = 100;

			Invoke ("alarm", 1);

		}
	}
	void alarm(){
		if (Vision >= 1) {
			print ("Trigger Is active");
		}

	}
}
