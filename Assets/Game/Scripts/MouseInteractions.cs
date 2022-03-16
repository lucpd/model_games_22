using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInteractions : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
        RaycastHit hit;

        var ray = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);

        // If it hits but the object also has a rigidbody
        if (Physics.Raycast(ray, out hit) && hit.rigidbody != null)
        {
            hit.rigidbody.AddForce(new Vector3(-20, 1, 20), ForceMode.Impulse);
        }
    }
}