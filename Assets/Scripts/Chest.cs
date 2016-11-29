using UnityEngine;
using System.Collections;

public class Chest : MonoBehaviour {

	public int gold = 10;

	void OnTriggerEnter(Collider collider) {

		if (collider.CompareTag ("Player")) {

			Wallet wallet = collider.gameObject.GetComponent<Wallet> ();
			wallet.gold = wallet.gold + gold;
			Destroy (gameObject);
		}
	}
}
