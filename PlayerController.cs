using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

	public string levelToLoad;
	public float speed;
	public Vector3 PlayerStart;
	public GameObject Player;
	private Rigidbody rb;
	public int PickUpsCollect;
	private bool PlayerWin = false;

	// Use this for initialization
	void Start ()
	{
		rb = GetComponent<Rigidbody> ();
		PlayerStart = Player.transform.position;
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

		if(PlayerWin == true)
			SceneManager.LoadScene(levelToLoad);
	}
}
