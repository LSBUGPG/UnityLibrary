using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour {
	public GameObject pauseMenu;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.P)) {
			if (Time.timeScale == 1) {
				Time.timeScale = 0;
				pauseMenu.SetActive (true);
			} else {
				Time.timeScale = 1;
				pauseMenu.SetActive (false);
			}
		}
	}
}
