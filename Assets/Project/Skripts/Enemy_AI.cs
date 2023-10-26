using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy_AI : MonoBehaviour
{
    public NavMeshAgent agent;
    public Animator anim;
    void Update()
    {
        agent.destination = Teleport.rid.transform.position;
        anim.SetFloat("Speed",agent.velocity.magnitude);
    }
}
