using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour
{
	public GameObject bullet;
	public Transform spawnPoint;

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			Instantiate(bullet, spawnPoint.position, spawnPoint.rotation);
		}
	}
}
