using UnityEngine;
using System.Collections;

public class RandomPosition : MonoBehaviour
{
	public Vector3 range = Vector3.zero;
	Vector3 initialPosition;

	void Start()
	{
		initialPosition = transform.position;
	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			Randomize();
		}
	}

	public void Randomize()
	{
		var randomX = initialPosition.x + Random.Range(-range.x, range.x);
		var randomY = initialPosition.y + Random.Range(-range.y, range.y);
		var randomZ = initialPosition.z + Random.Range(-range.z, range.z);

		transform.position = new Vector3(randomX, randomY, randomZ);
	}
}
