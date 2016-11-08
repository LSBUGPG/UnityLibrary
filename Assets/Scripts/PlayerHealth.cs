using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {

	public int lives = 10;
	DodgeMover dm;
	public Slider healthSLider;
	public Text evasionScore;
	int score;
	public int dodgeScore;


	void Start () {
		dm = GetComponent<DodgeMover> ();
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Projectile" && dm.movementLock == false) {
			lives--;
			Destroy(other.gameObject);
			Debug.Log ("Test");
			healthSLider.value = lives;
		} else {
			score += dodgeScore;
			evasionScore.text = string.Format ("Evasion Score: {0}", score);
		}
		if (lives <= 0) {
			Destroy(gameObject);
		}
	}
}
