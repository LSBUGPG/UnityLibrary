using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour 
{
	public Vector3 RespawnPosition = Vector3.zero;

	// Use this for initialization
	void Start () 
	{
		float x = PlayerPrefs.GetFloat ("PosX", transform.position.x);
		float y = PlayerPrefs.GetFloat ("PosY", transform.position.y);
		float z = PlayerPrefs.GetFloat ("PosZ", transform.position.z);

		//Get start position
		RespawnPosition = new Vector3(x, y, z);

		Respawn ();
	}

	public void Respawn()
	{
		transform.position = RespawnPosition;
	}

	void Update()
	{
		if (Input.GetKeyDown (KeyCode.Space)) 
			Respawn ();
		
	}
}
