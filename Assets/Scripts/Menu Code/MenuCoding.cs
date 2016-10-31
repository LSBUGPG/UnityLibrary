using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
//Scene.name
//Scene.buildIndex

public class MenuCoding : MonoBehaviour {
	Scene CurrentScene = SceneManager.GetActiveScene(); // Gets the current scene for the game.
	// Use this for initialization
	void Start () {
		CurrentScene = SceneManager.GetActiveScene(); // On game start, grabs the current scene (in case another script changes it before this one loads).
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ExitGame() {
      //  PlayerPrefs.SetInt("currentLevel", DataKeeper.current.currentLevel);
        Application.Quit(); // On exit call the quit function that will close the .exe down.
    }

	public void PlayGame() {
		SceneManager.LoadScene (1); // Uses the scene manager to load the desired scene. Argument as string name or index number.

	}

}
