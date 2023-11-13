using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public AudioClip kesh, kik;
    public Color[] collors;
    public SpriteRenderer flag;
    public Animator anim;
    public int num;
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
            if (num == other.GetComponent<Enemy_AI>().num)
            {
                GameInterfase.rid.his_Cor += 1;
                SoundPlayer.regit.sorse.PlayOneShot(kesh);
            }
            else
            {
                SoundPlayer.regit.sorse.PlayOneShot(kik);
                Block.rid.Damage();
                if (GameInterfase.rid.his_Cor > 0)
                {
                    GameInterfase.rid.his_Cor -= 1;
                }
            }
        }
    }
    public void Rendom()
    {
        if (num > 0)
        {
            num -= 1;
        }
        else
        {
            num = collors.Length - 1;
        }
        
    }
    private void Update()
    {
        flag.transform.Rotate(Vector3.forward * 2);
        flag.color = collors[num];
    }
}
