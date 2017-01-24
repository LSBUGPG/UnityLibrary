using UnityEngine;
using System.Collections;

public class DodgeMover : MonoBehaviour {

	public float speed = 5f;
	public float dodgeTimer = 20f;
	public bool dodgeLock = false;
	public bool timerLock = false;
	public bool movementLock = false;
	Vector3 latestMoveDir;
	private int dodgeCount;


	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
	
		if (Input.GetKey (KeyCode.LeftArrow) && movementLock == false) {

			transform.Translate (Vector3.left * Time.deltaTime * speed);
			latestMoveDir.x = -1;
		}

		if (Input.GetKey (KeyCode.RightArrow) && movementLock == false) {

			transform.Translate (Vector3.right * Time.deltaTime * speed);
			latestMoveDir.x = 1;
		}

		if (Input.GetKey (KeyCode.UpArrow) && movementLock == false) {

			transform.Translate (Vector3.forward * Time.deltaTime * speed);
			latestMoveDir.z = 1;
		}

		if (Input.GetKey (KeyCode.DownArrow) && movementLock == false) {

			transform.Translate (Vector3.back * Time.deltaTime * speed);
			latestMoveDir.z = -1;
		}

		if (Input.GetKeyUp(KeyCode.UpArrow) && movementLock == false || Input.GetKeyUp(KeyCode.DownArrow) && movementLock == false) {
			latestMoveDir.z = 0;
		}
		if (Input.GetKeyUp(KeyCode.LeftArrow)  && movementLock == false|| Input.GetKeyUp(KeyCode.RightArrow) && movementLock == false) {
			latestMoveDir.x = 0;
		}


		if (Input.GetKeyDown (KeyCode.Space) && dodgeLock == false) {
			speed = 20f;
			movementLock = true;
			timerLock = true;
		}

		if (timerLock == true) {
			dodgeTimer = dodgeTimer - 1;
			dodgeLock = true;
		}
		if (movementLock == true) {
			transform.Translate (latestMoveDir * Time.deltaTime * speed);
		}
		if (dodgeTimer <= 0) {
			speed = 0;
			movementLock = false;

		}
		if (dodgeTimer <= -30) {
			timerLock = false;
			dodgeTimer = 20;
			speed = 5;
		}


		if (dodgeTimer == 20) {
			dodgeLock = false;
			timerLock = false;
		}
	}
}