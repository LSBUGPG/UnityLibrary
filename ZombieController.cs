using UnityEngine;
using System.Collections;

public class ZombieController : MonoBehaviour {

	// this is a transform, this shows the zombies who to chase.
	public Transform Player;
	public NavMeshAgent nav;
	//this reperesents the zombie on the map


	// Use this for initialization
	void Awake () {

	
		Player = GameObject.FindGameObjectWithTag ("Player").transform;
		nav = GetComponent <NavMeshAgent> ();
	
	}
	
	// Update is called once per frame
	void Update () {

		//this tells the zombie to chase the player
			nav.SetDestination (Player.position);
			
		} 
	
	}
