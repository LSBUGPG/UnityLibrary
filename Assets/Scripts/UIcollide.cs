using UnityEngine;
using System.Collections;

public class UIcollide : MonoBehaviour {

	public GameObject UI;

	void OnTriggerEnter(Collider Other)
	{
		if (Other.CompareTag ("Player"))
			UI.SetActive(true);
	}
}
		
