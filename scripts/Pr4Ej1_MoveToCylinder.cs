using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pr4Ej1_MoveToCylinder : MonoBehaviour
{
    Vector3 direction;
    Pr4Ej1_SphereManager sphereManager;
    Transform cylinder_tf;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        sphereManager = GameObject.Find("SphereManager").GetComponent<Pr4Ej1_SphereManager>();
        cylinder_tf = GameObject.Find("Cylinder").transform;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        direction = cylinder_tf.position - transform.position;
        rb.AddForce(direction * sphereManager.speed);
    }
}
