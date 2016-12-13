using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter (Collider Other)
	{
		if (!Other.CompareTag ("Player")) 
			return;
		
		Destroy (Other.gameObject);
		Application.LoadLevel ("SceneName");
		
		
	}
}
