using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wey : MonoBehaviour
{
    public float speed;
    void Update()
    {
        transform.position -= transform.forward * speed * Time.deltaTime;
        if (transform.position.z <= -40)
        {
            transform.position = new Vector3(0,0,20);
        }
    }
}
