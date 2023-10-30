using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnEmiter : MonoBehaviour
{
    public AudioClip emit;
    public GameObject[] enemy;
    public float interval;
    public ParticleSystem pS;
    private float timer;
    private void Start()
    {
        timer = Time.time;
    }
    void Emit()
    {
        int num = Random.Range(0, enemy.Length);
        //SoundPlayer.regit.sorse.PlayOneShot(emit);
        Instantiate(enemy[num], transform.position, Quaternion.identity);
        timer = Time.time;
        //pS.Play();
    }
    private void Update()
    {
        if (Time.time > (timer + Random.Range(interval, interval * 2)))
        {
            Emit();
        }
    }
}
