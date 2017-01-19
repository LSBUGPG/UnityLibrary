using UnityEngine;
using System.Collections;

public class LifeController : MonoBehaviour {

	public int Camlife = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Camlife < 1) {
			print ("Lost Life");
		}
		if (Input.GetKeyDown(KeyCode.V) && Camlife > 0) {
			Camlife = Camlife - 1;
		}
		if (Input.GetKeyDown(KeyCode.B) && Camlife < 3) {
			Camlife = Camlife + 1;
		}
	}

	void GainLife()
	{
		if (Camlife < 3) {
			Camlife = Camlife + 1;
		}

	}
}
