using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Animator anim;
    public static Teleport rid { get; set; }
    void Awake()
    {
        anim.SetFloat("Speed", 0);
        if (rid == null)
        {
            rid = this;
        }
        else
        {
            Destroy(this);
        }
    }
    void OnDestroy()
    {
        rid = null;
    }
    public void Resed()
    {
        anim.SetFloat("Speed", 0);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            anim.SetFloat("Speed",1);
            Destroy(other.gameObject);
        }
    }
}
