using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreGain : MonoBehaviour {

	public Text points;
	int score = 0;

	// Use this for initialization
	void Start () {
	
	}

	void Update(){
		points.text = string.Format ("Points: {0}", score);
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider other)
	{
		if (other.tag == "Player") {
			score += 10;
		}
	}
}