using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Health : MonoBehaviour {

	public int lives = 10;
	public Slider healthSLider;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider other)
	{
		if (other.tag == "Projectile") {
			lives--;
			Destroy (other.gameObject);
			healthSLider.value = lives;

			if (lives <= 0) {
				GameOver ();
			}
		}
	}

	void GameOver ()
	{
		Destroy (gameObject);
	}
}
