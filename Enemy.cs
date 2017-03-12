using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	public int EnemyHealth = 5;
	public int TestStickdammage = 0;
	public int testAxedammage = 0;
	public int testspeardammage = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (EnemyHealth <= 0) {
			Destroy (gameObject);
			Debug.Log ("Aggh, i'm dead!");
		}
		
	}
	void OnTriggerEnter (Collider other) {

		if (other.CompareTag ("TestStick")) {
			Debug.Log ("ow, you hit Me!");
			EnemyHealth -= TestStickdammage;
		} else if (other.CompareTag ("spear")) {
			Debug.Log ("ow, you hit Me!");
			EnemyHealth -= testspeardammage;
		}
				else if (other.CompareTag ("Axe")) {
					EnemyHealth -= testAxedammage;
				}
			}
			
		}

