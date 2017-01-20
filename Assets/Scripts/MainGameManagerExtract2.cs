using UnityEngine;
using System.Collections;

public class MainGameManagerExtract2 : MonoBehaviour {

	public LavaRise LR;
	public bool GamePlaying = true;
	public bool CanCompleteLevel = false;

	// Use this for initialization
	void Start () {
		LR.Invoke ("Activate", 15);
	}

	// Update is called once per frame
	void Update () {

	}
}
