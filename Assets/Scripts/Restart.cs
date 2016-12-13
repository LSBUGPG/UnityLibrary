using UnityEngine;
using System.Collections;

public class Restart : MonoBehaviour {


	public CameraSwitch enemy1;
	public CameraSwitch enemy2;
	public CameraSwitch enemy3;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void RestartEnemies(){

		enemy1.Restart ();
		enemy2.Restart ();
		enemy3.Restart ();

	}
}
