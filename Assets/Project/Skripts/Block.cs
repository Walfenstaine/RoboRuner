using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public Animator anim;
    public static Block rid { get; set; }
    void Awake()
    {
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
    private void Start()
    {
        anim.SetFloat("Speed", 0); 
    }

    public void Damage()
    {
        anim.SetBool("Kik", true);
    }
    public void Resed()
    {
        anim.SetBool("Kik", false);
    }
}
