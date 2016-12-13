using UnityEngine;
using System.Collections;

public class CharSwap : MonoBehaviour {

	public GameObject[] cameras;
	public GameObject[] players;

	private int CameraIndex;
	private int playersIndex; 

	private bool m_isFirstPlayer = true;
	// Use this for initialization
	void Start () {
		CameraIndex = 0;
		playersIndex = 0;


		//Set up Player
		for (int p = 1; p < players.Length; p++) {
			players [p].GetComponent<PlayerController>().enabled = (false);

		}
		if (players.Length > 0) {
			players [0].GetComponent<PlayerController> ().enabled = true;

		}
	}
	
	// Update is called once per frame
	void Update () {
		

		if (Input.GetKeyDown (KeyCode.O)) 
		{
			ChangePlayer (0);
		}
		if (Input.GetKeyDown (KeyCode.P)) {
			ChangePlayer (1);
		}
	}

	void ChangePlayer(int playersIndex)
	{
		for (int i = 0; i < players.Length; i++) 
		{
			if (i == playersIndex) {
				players [i].GetComponent<PlayerController> ().enabled = false;

			} else {
				players [i].GetComponent<PlayerController> ().enabled = true;

			}
		}
	}
}
