using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    [SerializeField] public NavMeshAgent agent;
    [SerializeField] public Animator animator;
    GameObject player;
    public float lookRadius = 20f;
    
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            if (agent.remainingDistance != Mathf.Infinity && agent.remainingDistance <= agent.stoppingDistance)
            {
                agent.destination = player.transform.position;
                animator.SetBool("IsWalking", false);
            }

            else if (agent.remainingDistance <= lookRadius)
            {
                agent.destination = player.transform.position;
                animator.SetBool("IsWalking", true);
            }
        }
    }
}
