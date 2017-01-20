using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RockPaperScissorsEnemy : MonoBehaviour {

	public int elementChoice;

	public bool[] elements;

	private string[] choices = {"Fire","Water","Wind","Earth","Lightning"}; 

	public Text choiceText;


	// Use this for initialization
	void Start () {
		elementChoice = Random.Range (0, elements.Length);
	}
	
	// Update is called once per frame
	void Update () {
	
		for (int element = 0; element < 5; ++element) {

			elements [element] = (element == elementChoice);

		}

		/*

		if (elementChoice == 0) {
			elements [0] = true;

			elements [1] = false;
			elements [2] = false;
			elements [3] = false;
			elements [4] = false;
		}

		if (elementChoice == 1) {
			elements [1] = true;

			elements [0] = false;
			elements [2] = false;
			elements [3] = false;
			elements [4] = false;
		}
		if (elementChoice == 2) {
			elements [2] = true;

			elements [0] = false;
			elements [1] = false;
			elements [3] = false;
			elements [4] = false;
		}
		if (elementChoice == 3) {
			elements [3] = true;

			elements [0] = false;
			elements [1] = false;
			elements [2] = false;
			elements [4] = false;
		}
		if (elementChoice == 4) {
			elements [4] = true;

			elements [0] = false;
			elements [1] = false;
			elements [2] = false;
			elements [3] = false;
		}
		*/
	}

	public void EnemyChoice () {
	
		elementChoice = Random.Range (0, elements.Length);
		choiceText.text += "Enemy: " + choices [elementChoice]+"\n";
	}
}
