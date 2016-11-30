using UnityEngine;
using System.Collections;

public class KeyMove : MonoBehaviour {
	
		// Use this for initialization
		void Start () {
			
			}

		// Update is called once per frame
		void Update () {
		
			 if(Input.GetButtonDown("left"))
						{
			
						transform.Translate (Vector3.left * Time.deltaTime);
					}
		
					if(Input.GetButtonDown("right")) {
			
						transform.Translate (Vector3.right * Time.deltaTime);
					}

					if(Input.GetButtonDown("up")) {
			
						transform.Translate (Vector3.forward * Time.deltaTime);
					}

							if(Input.GetButtonDown("down")) {
			
						transform.Translate (Vector3.back * Time.deltaTime);
					}
			}
	}