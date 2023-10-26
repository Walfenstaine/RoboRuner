using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public int damag;
    public ParticleSystem ps;

    public void Shut()
    {
        ps.Play();
        RaycastHit hit;
        Ray ray = new Ray(transform.position, transform.forward);
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.tag == "Block")
            {
                hit.collider.GetComponent<Block>().Damage(damag);
            }
        }
    }
    void Update()
    {
        transform.eulerAngles = Vector3.zero;
    }
}
