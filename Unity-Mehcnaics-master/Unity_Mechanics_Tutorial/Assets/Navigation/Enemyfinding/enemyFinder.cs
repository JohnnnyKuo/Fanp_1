using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemyFinder : MonoBehaviour
{
    [SerializeField] Transform target;

    NavMeshAgent agent;

 
    void Start()
    {
        agent=GetComponent<NavMeshAgent>();
        agent.updateUpAxis=false;
        agent.updateRotation=false;

    }
    private void Update() 
    {
        agent.SetDestination(target.position);
    }
}
