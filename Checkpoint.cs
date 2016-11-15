using UnityEngine;
using System.Collections;

public class Checkpoint : MonoBehaviour 
{
	void OnTriggerEnter(Collider Col)
	{
		if (!Col.CompareTag ("Player"))
			return;

		PlayerController PC = Col.GetComponent<PlayerController> ();
		PC.RespawnPosition = transform.position;

		//Save Position
		PlayerPrefs.SetFloat("PosX", transform.position.x);
		PlayerPrefs.SetFloat("PosY", transform.position.y);
		PlayerPrefs.SetFloat("PosZ", transform.position.z);
		PlayerPrefs.Save ();
	}
}
