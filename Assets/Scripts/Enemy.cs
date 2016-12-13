using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{
    [HideInInspector]
    public bool hasFired = false;
    public GameObject target;

	void OnTriggerEnter (Collider Other)
	{
		if (!Other.CompareTag ("Player")) 
			return;

		Destroy (Other.gameObject);
		Application.LoadLevel ("SceneName");
	}

    public void Shoot()
    {
        Debug.Log(name + " shot at " + target.name);
        hasFired = true;
    }
}
