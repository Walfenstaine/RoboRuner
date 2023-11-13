using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnEmiter : MonoBehaviour
{
    public Data data;
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
        if (data.record < 70)
        {
            interval = (100 - data.record) / 10;
        }
        else
        {
            interval = 3;
        }
        
        int num = Random.Range(0, enemy.Length);
        pS.Play();
        Instantiate(enemy[num], transform.position, Quaternion.identity);
        timer = Time.time;
    }
    private void Update()
    {
        if (Time.time > (timer + Random.Range(interval, interval * 2)))
        {
            Emit();
        }
    }
}
