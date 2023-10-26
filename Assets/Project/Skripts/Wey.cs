using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wey : MonoBehaviour
{
    private float speed;

    private void Start()
    {
        speed = Muwer.rid.speed;
    }
    void Update()
    {
        transform.position -= transform.forward * speed * Time.deltaTime;
        if (transform.position.z <= -40)
        {
            transform.position = new Vector3(0,0,20);
        }
    }
}
