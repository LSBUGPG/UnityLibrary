using UnityEngine;
using System.Collections;

public class Wallet : MonoBehaviour {

	public int gold = 10;

	void Store(int deposit) {

		gold = gold + deposit;
	}
}
