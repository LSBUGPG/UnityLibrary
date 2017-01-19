using UnityEngine;
using System.Collections;

public class NavFollower : MonoBehaviour
{
    private NavMeshAgent ThisAgent = null;
    public Transform Destination = null;
    // Use this for initialization
    void Awake()
    {
        ThisAgent = GetComponent<NavMeshAgent>();
    }

    private void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        try
        {
            ThisAgent.SetDestination(Destination.position);
        }
        catch (UnassignedReferenceException)
        {
            
        }
    }
}
