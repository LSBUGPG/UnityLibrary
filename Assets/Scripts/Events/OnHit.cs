using UnityEngine;
using System.Collections;

public class OnHit : MonoBehaviour
{
	public int hitDamage;

	void Start()
	{

	}

	void Update()
	{
		if (PlayerStats.isDead)
		{
			Debug.Log("Player is dead");
		}

		else
		{
			Debug.Log("Player health: " + PlayerStats.health);
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Trap")
		{
			PlayerStats.health -= hitDamage;

			if (PlayerStats.health <= 0)
			{
				PlayerStats.health = 0;
				PlayerStats.isDead = true;
			}
		}
	}
}
