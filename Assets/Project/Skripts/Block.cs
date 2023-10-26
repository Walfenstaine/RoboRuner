using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Block : MonoBehaviour
{
    public GameObject boom;
    public ParticleSystem ps;
    public Text text;
    public int helse;
    private float speed;

    private void Start()
    {
        speed = Muwer.rid.speed;
    }

    public void Damage(int damag)
    {
        if (damag < helse)
        {
            helse -= damag;
            ps.Play();
        }
        else
        {
            Destroy(gameObject);
            Instantiate(boom, transform.position, Quaternion.identity);
        }
    }
    void Update()
    {
        if (transform.position.z > -10)
        {
            text.text = "" + helse;
            transform.position -= transform.forward * speed * Time.deltaTime;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
