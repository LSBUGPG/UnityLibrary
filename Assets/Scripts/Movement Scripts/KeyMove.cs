using UnityEngine;
using System.Collections;

public class KeyMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
	
		 if(Input.GetButtonDown("HorizontalNegative"))
			{

			transform.Translate (Vector3.left * Time.deltaTime);
		}

			if(Input.GetButtonDown("HorizontalPositive")) {

			transform.Translate (Vector3.right * Time.deltaTime);
		}

				if(Input.GetButtonDown("VerticalPositive")) {

			transform.Translate (Vector3.forward * Time.deltaTime);
		}

					if(Input.GetButtonDown("VerticalNegative")) {

			transform.Translate (Vector3.back * Time.deltaTime);
		}
	}
}
