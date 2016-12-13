using System.Collections;
using UnityEngine.AI;
using UnityEngine;

public class EnemyController : MonoBehaviour {

	public Transform target = null;
	private NavMeshAgent ThisAgent = null;
	public Vector3 PlayerStart;
	public GameObject Player;

	// Use this for initialization
	void Start () {

		ThisAgent = GetComponent<NavMeshAgent> ();
		ChooseTarget ();

		PlayerStart = Player.transform.position;
	}

	void ChooseTarget()
	{
		GameObject[] Targets = GameObject.FindGameObjectsWithTag ("target");
		target = Targets[Random.Range(0,Targets.Length)].transform;
	}
	
	// Update is called once per frame
	void Update ()
	{
		ThisAgent.SetDestination (target.position);

		if (Vector3.Distance (transform.position, target.position) < ThisAgent.stoppingDistance)
			ChooseTarget ();
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("Player"))
			Player.transform.position = PlayerStart;
	}
}