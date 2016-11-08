using UnityEngine;
using System.Collections;

public class MoveOnPath : MonoBehaviour
{
	public PathManager PathToFollow;

	public int CurrentWayPointID = 0;
	public float speed;
	private float reachDistance = 1.0f;
	public float rotationSpeed = 5.0f;
	public string pathName;

	Vector3 last_position;
	Vector3 current_position;

	void Start ()
	{
		last_position = transform.position;
	}

	void Update ()
	{
		float distance = Vector3.Distance (PathToFollow.path_objs [CurrentWayPointID].position, transform.position);
		transform.position = Vector3.MoveTowards (transform.position, PathToFollow.path_objs [CurrentWayPointID].position, Time.deltaTime * speed);

		var rotation = Quaternion.LookRotation (PathToFollow.path_objs [CurrentWayPointID].position - transform.position);
		transform.rotation = Quaternion.Slerp (transform.rotation, rotation, Time.deltaTime * rotationSpeed);

		if (distance <= reachDistance) {
			CurrentWayPointID++;	
		}

		if (CurrentWayPointID >= PathToFollow.path_objs.Count) {
			CurrentWayPointID = 0;
		}
	}
}
