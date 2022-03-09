using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInteractions : MonoBehaviour
{

    public Transform ballT;
    
    void Start()
    {
      
    }

    void FixedUpdate()
    {

        RaycastHit hit;

        var ray = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);

        // If it hits but the object also has a rigidbody
        if (Physics.Raycast(ray, out hit))
        {
            Vector3 dir = hit.point - ballT.position;
            ballT.GetComponent<Rigidbody>().AddForce(dir * 5);
            //hit.rigidbody.AddForce(new Vector3(1, 0 , 1), ForceMode.Impulse);
        }
    }
}