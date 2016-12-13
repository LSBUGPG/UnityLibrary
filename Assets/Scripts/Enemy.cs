using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{
    [HideInInspector]
    public bool hasFired = false;
    public GameObject target;

    public void Shoot()
    {
        Debug.Log(name + " shot at " + target.name);
        hasFired = true;
    }
}
