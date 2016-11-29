using UnityEngine;
using System.Collections;

public class Chest : MonoBehaviour {

	public int gold = 10;

	void Collect(Component container) {

		container.SendMessage("Store", gold);
		Destroy (gameObject);
	}
}
