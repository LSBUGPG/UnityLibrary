using UnityEngine;
using System.Collections;

public class DodgeMover : MonoBehaviour {

	float speed;
	public float dodgeTime = 20;
	public int dodgeSpeed = 20;
	public int normalSpeed = 5;
	float dodgeTimer;
	public bool dodgeLock = false;
	public bool timerLock = false;
	public bool movementLock = false;
	public Rigidbody rb;
	Vector3 latestMoveDir;
	private int dodgeCount;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		dodgeTimer = dodgeTime;
		speed = normalSpeed;
	}

	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKey (KeyCode.LeftArrow) && movementLock == false) 
		{
			//rb.AddForce(-transform.right * speed);
			//latestMoveDir.x = -1;
			transform.Translate (Vector3.left * Time.deltaTime * speed);
			latestMoveDir = Vector3.back + Vector3.left;
		}

		if (Input.GetKey (KeyCode.RightArrow) && movementLock == false) {

			//rb.AddForce (transform.right * speed);
			//latestMoveDir.x = 1;
			transform.Translate (Vector3.right * Time.deltaTime * speed);

			latestMoveDir = Vector3.forward + Vector3.right;
		}

		if (Input.GetKey (KeyCode.UpArrow) && movementLock == false) {

			//rb.AddForce (transform.forward * speed);
			//latestMoveDir.z = 1;
			transform.Translate (Vector3.forward * Time.deltaTime * speed);
			latestMoveDir = Vector3.forward + Vector3.left;
		}

		if (Input.GetKey (KeyCode.DownArrow) && movementLock == false) {

			//rb.AddForce (-transform.forward * speed);
			//latestMoveDir.z = -1;
			transform.Translate (Vector3.back * Time.deltaTime * speed);
			latestMoveDir = Vector3.back + Vector3.right;
		}



		if ((Input.GetKeyUp(KeyCode.UpArrow) && movementLock == false) || (Input.GetKeyUp(KeyCode.DownArrow) && movementLock == false)) {
			latestMoveDir.z = 0;
		}
		if ((Input.GetKeyUp(KeyCode.LeftArrow)  && movementLock == false) || (Input.GetKeyUp(KeyCode.RightArrow) && movementLock == false)) {
			latestMoveDir.x = 0;
		}


		if (Input.GetKeyDown (KeyCode.Space) && dodgeLock == false && latestMoveDir != Vector3.zero) {
			speed = dodgeSpeed;
			movementLock = true;
			timerLock = true;
		}

		if (timerLock == true) {
			dodgeTimer = dodgeTimer - 1;
			dodgeLock = true;
		}
		if (movementLock == true) {
			//rb. = latestMoveDir * speed * Time.deltaTime;
			//transform.Translate (latestMoveDir * Time.deltaTime * speed);
			rb.MovePosition(transform.position + latestMoveDir * speed * Time.deltaTime);
			//rb.AddForce (latestMoveDir * speed);
		}
		if (dodgeTimer <= 0) {
			speed = 0;
			movementLock = false;

		}
		if (dodgeTimer <= -30) {
			timerLock = false;
			dodgeTimer = dodgeTime;
			speed = normalSpeed;
		}
			
		if (dodgeTimer == dodgeTime) {
			dodgeLock = false;
			timerLock = false;
		}

		//Nomral move
		//rb.velocity = Vector3.ClampMagnitude (rb.velocity, speed);
		rb.velocity = Vector3.zero;
	}
}