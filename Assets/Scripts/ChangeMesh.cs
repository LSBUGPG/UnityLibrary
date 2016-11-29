using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ChangeMesh : MonoBehaviour
{
	public Mesh firstMesh, secondMesh;
	List<Mesh> meshes;
	int currentMesh = 0;

	[SerializeField]
	GameObject cilindro;

	void Awake()
	{
		meshes = new List<Mesh>();
		meshes.Add(GetComponent<MeshFilter> ().mesh);
		meshes.Add(firstMesh);
		meshes.Add(secondMesh);
		meshes.Add (cilindro.GetComponent<MeshFilter> ().mesh);
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

			GetComponent<MeshFilter>().mesh = meshes[currentMesh];

		}
	}
}
