using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "cube")
        {
            collision.gameObject.GetComponent<Renderer>().material = gameObject.GetComponent<Renderer>().material;
        }
    }
}

