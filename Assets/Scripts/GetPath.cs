using UnityEngine;
using System.Collections;

[RequireComponent(typeof(MoveOnPath))]
public class GetPath : MonoBehaviour
{
	public GameObject[] allPaths;

	void Start ()
	{
		int num = Random.Range (0, allPaths.Length);
		transform.position = allPaths [num].transform.position;
		MoveOnPath yourPath = GetComponent<MoveOnPath> ();
		yourPath.pathName = allPaths [num].name;
	}
}
