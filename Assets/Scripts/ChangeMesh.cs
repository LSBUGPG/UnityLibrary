using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ChangeMesh : MonoBehaviour
{
	public Mesh firstMesh, secondMesh;
	List<Mesh> meshes;
	int currentMesh = 0;

	void Awake()
	{
		meshes = new List<Mesh>();
		meshes.Add(firstMesh);
		meshes.Add(secondMesh);
	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			currentMesh++;

			if (currentMesh == meshes.Count)
			{
				currentMesh = 0;
			}

			gameObject.GetComponent<MeshFilter>().mesh = meshes[currentMesh];
		}
	}
}
