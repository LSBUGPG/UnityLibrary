﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class myTimer : MonoBehaviour {

	private float timeRemaining = 30.0f;
	public Text timer;

	void start()
	{
		
	}
	// Update is called once per frame
	void Update () {
		timeRemaining -= Time.deltaTime; 
		timer.text = "Time Remaining: " + Mathf.RoundToInt(timeRemaining);

	

	}

}