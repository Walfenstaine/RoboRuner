using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy_AI : MonoBehaviour
{
    public GameObject nagrada;
    public NavMeshAgent agent;
    public Animator anim;

    public void Ded()
    {
        Instantiate(nagrada, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
    void Update()
    {
        agent.destination = Teleport.rid.transform.position;
        anim.SetFloat("Speed",agent.velocity.magnitude);
    }
}
