using UnityEngine;
using System.Collections;

public class Collector : MonoBehaviour {

	public Component storage;

	void OnTriggerEnter(Collider collider) {

		collider.SendMessage ("Collect", storage, SendMessageOptions.DontRequireReceiver);
	}
}
