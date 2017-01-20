using UnityEngine;
using System.Collections;

public class LavaRise : MonoBehaviour {

	public MainGameManagerExtract2 MGM;

	public bool Active = false;
	public float Speed = 0.001f;
	public float Rate = 0.25f; // Update per second
	private float Count = 0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (MGM.GamePlaying == true && Active == true){ //&& Count/60 >= Rate) {
			//Count = 0;
			transform.position = transform.position + new Vector3 (0,Speed,0);
		}
	}

	public void Activate(){
		Active = true;
	}
	public void Pause(){
		Active = false;
	}
}
