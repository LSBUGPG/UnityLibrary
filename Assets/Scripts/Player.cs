using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
	// We will need this variable to store the value of the speed before the powerup updates it
	int normalSpeed;
	
	// Create a variable that will serve as reference to the powerup component
	PowerUp powerUp;

	void Awake()
	{
		// Get the current speed from the movement component attached to the player
		normalSpeed = GetComponent<Movement>().speed;
	}

	// As soon as we collide with a trigger, we get a variable named info with the information of who we collide with
	void OnTriggerEnter(Collider info)
	{
		// If we collide with a GameObject that is tagged as PowerUp
		if (info.tag == "PowerUp")
		{
			// As we collided with a PowerUp, we can assign its component PowerUp to our powerup reference
			powerUp = info.GetComponent<PowerUp>();
			
			// Now that we have the reference setted we can destroy the gameobject from the scene
			Destroy(info.gameObject);
			
			// Now we multiply our current speed by the speedfactor assigned in the powerup component
			GetComponent<Movement>().speed *= powerUp.speedFactor;
			
			// And as we want to have a countdown that sets the speed back to normal, we start a coroutine that will do that
			StartCoroutine("Countdown");
		}
	}

	IEnumerator Countdown()
	{
		// Halt the code inside this function for the amount of time we set on the powerup
		yield return new WaitForSeconds(powerUp.countdownFrom);
		
		// Set the current speed back to normal
		GetComponent<Movement>().speed = normalSpeed;
	}
}
