using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Vector3 moveVector = Vector3.zero;
   

    public float moveSpeed;
    public float jumpSpeed;
    public float gravity;

    void Start()
    {
        
    }

    void Update()
    {
        moveVector.x = Input.GetAxis("Horizontal") * moveSpeed;
        moveVector.z = Input.GetAxis("Vertical") * moveSpeed;

       // Vector3.Move(moveVector * Time.deltaTime);
    }
}

