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


	// Use this for initialization
	void Start () {
		
		rb = GetComponent<Rigidbody> ();
		dodgeTimer = dodgeTime;
		speed = normalSpeed;
	}

	// Update is called once per frame
	void Update () 
	{
		if (!movementLock) {
		
			latestMoveDir = Vector3.zero;

			if (Input.GetKey (KeyCode.LeftArrow)) {

				latestMoveDir += Vector3.left;
			}

			if (Input.GetKey (KeyCode.RightArrow)) {

				latestMoveDir += Vector3.right;
			}

			if (Input.GetKey (KeyCode.UpArrow)) {

				latestMoveDir += Vector3.forward;
			}

			if (Input.GetKey (KeyCode.DownArrow)) {

				latestMoveDir += Vector3.back;
			}
		}

		if (Input.GetMouseButtonDown (0) && dodgeLock == false && latestMoveDir != Vector3.zero) {
			
			speed = dodgeSpeed;
			movementLock = true;
			timerLock = true;
		}

		if (timerLock == true) {
			
			dodgeTimer = dodgeTimer - 1;
			dodgeLock = true;
		}

		rb.MovePosition(transform.position + latestMoveDir * speed * Time.deltaTime);

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
		rb.velocity = Vector3.zero;
	}
}