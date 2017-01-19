using UnityEngine;
using System.Collections;

public class EnemyMovement1 : MonoBehaviour {
	
	private Transform ThisTransform = null;
	public float Speed;
	public float RightLimit;
	public float LeftLimit;


	// Use this for initialization
	void Start () {
		ThisTransform = GetComponent<Transform> ();

	}
	
	// Update is called once per frame
	void Update () {

		ThisTransform.position += ThisTransform.forward * Speed * Time.deltaTime;
	

		if (ThisTransform.position.x <= LeftLimit) {
			ThisTransform.position = new Vector3 (RightLimit, ThisTransform.position.y, ThisTransform.position.z);

		}
	}
	void OnTriggerEnter (Collider Other)
	{
		if (!Other.CompareTag ("Player")) 
			return;
		
		Destroy (Other.gameObject);
		

	}
}
