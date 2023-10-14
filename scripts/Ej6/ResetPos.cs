using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPos : MonoBehaviour
{
    Rigidbody rb;
    Vector3 default_position;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        default_position = new Vector3(4.957376f, 0.5f, 1.637243f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (transform.position.y < -10f) {
            rb.MovePosition(default_position);
            rb.velocity = Vector3.zero;
        }
    }
}
