using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy_AI : MonoBehaviour
{
    public AudioClip chwak, kik;
    public int num;
    public GameObject nagrada;
    public NavMeshAgent agent;
    public Animator anim;

    public void Ded()
    {
        if (num != Teleport.rid.num)
        {
            SoundPlayer.regit.sorse.PlayOneShot(chwak);
            GameInterfase.rid.his_Cor += 1;
        }
        else
        {
            Block.rid.Damage();
            SoundPlayer.regit.sorse.PlayOneShot(kik);
            if (GameInterfase.rid.his_Cor > 0)
            {
                GameInterfase.rid.his_Cor -= 1;
            }
               
        }
        
        Instantiate(nagrada, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
    void Update()
    {
        agent.destination = Teleport.rid.transform.position;
        anim.SetFloat("Speed",agent.velocity.magnitude);
    }
}
