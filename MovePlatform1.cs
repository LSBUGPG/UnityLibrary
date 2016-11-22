using UnityEngine;
using System.Collections;

public class MovePlatform1 : MonoBehaviour {

	public float Length = 5f;
	public float Speed = 1f;
	private Vector3 StartPos;
	private float PlusTime;
	private float LastLength = 0;
	private float LastSign = 1;

	void Start()
	{
		StartPos = transform.position;
		StartCoroutine (MyPlatformMove ());
	}

	void OnCollisionEnter(Collision adult){
		if (adult.gameObject.tag == "Player") {
			adult.transform.parent = transform;
		}
	}
		void OnCollisionExit(Collision adult){
			if (adult.gameObject.tag == "Player") {
				adult.transform.parent = null;
			}
	}

	public IEnumerator MyPlatformMove(){

		while (true) {
			float MyLength = Mathf.PingPong (PlusTime * Speed, Length);

			transform.position = StartPos + transform.forward * MyLength;

			float Sign = Mathf.Sign (MyLength - LastLength);

			LastLength = MyLength;

			if (LastSign != Sign)
			{
				yield return new WaitForSeconds (3f);
			}

			PlusTime += Time.deltaTime;

			LastSign = Sign;

			yield return null;
			}
		}
	}
