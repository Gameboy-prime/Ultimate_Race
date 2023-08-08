using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PathFinder : MonoBehaviour
{
    [SerializeField] private float attackRadius;

    private NavMeshAgent enemy;
    private Transform target;
    
    // Start is called before the first frame update
    void Start()
    {
        target = FindObjectOfType<CarController>().transform;
        
        enemy = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        
        float distance = Vector3.Distance(transform.position, target.position);
        if (distance <= attackRadius)
        {
            enemy.SetDestination(target.position);
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color=Color.yellow;
        Gizmos.DrawWireSphere(transform.position, attackRadius);
    }
}
