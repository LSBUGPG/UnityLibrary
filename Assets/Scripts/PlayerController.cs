using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour 
{
	public string levelToLoad;
	public float speed;
	private Rigidbody rb;
	public int PickUpsCollect;
	private bool PlayerWin = false;
	public Vector3 RespawnPosition = Vector3.zero;

	// Use this for initialization
	void Start () 
	{
		rb = GetComponent<Rigidbody> ();

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

	// Update is called once per frame
	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0f, moveVertical);

		rb.AddForce (movement * speed);
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("Pick Up")) {
			other.gameObject.SetActive (false);
			PickUpsCollect += 1;
		}

		if (PickUpsCollect >= 7)
			PlayerWin = true;

		if(PlayerWin)
			SceneManager.LoadScene(levelToLoad);
	}
}
