using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptController : MonoBehaviour
{
    float vertical;
    float horizontal;
    Rigidbody rb;
    Transform transf;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        transf = GetComponent<Transform>();
    }


    void Update()
    {
        vertical = Input.GetAxis("Vertical");
        horizontal = Input.GetAxis("Horizontal");
        rb.AddRelativeForce(0, 0, vertical*50f);
        transf.Rotate(0, horizontal, 0);
    }
}
