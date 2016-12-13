using UnityEngine;
using System.Collections;

public class UIDEACTIVEATE : MonoBehaviour {

		float UI = 1.0f;

		// Use this for initialization
		void Start () {

		}

		// Update is called once per frame
		void Update () {

			UI += Time.deltaTime;

			if (UI > 5.0f){
				gameObject.SetActive(false);
				UI = 0.0f;
			}
		}
	}
