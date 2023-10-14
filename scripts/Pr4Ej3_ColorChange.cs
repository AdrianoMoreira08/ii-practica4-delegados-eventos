using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pr4Ej3_ColorChange : MonoBehaviour
{
    public float force = 300f;
    Pr4Ej1_CubeCollision cubeCollision;
    Renderer this_renderer;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        this_renderer = GetComponent<Renderer>();
        rb = GetComponent<Rigidbody>();
        cubeCollision = GameObject.Find("Cylinder").GetComponent<Pr4Ej1_CubeCollision>();
        cubeCollision.OnCubeCollision += ChangeColorAndJump;
    }

    void ChangeColorAndJump() {
        this_renderer.material.color = Random.ColorHSV(0f, 1f,    // Hue
                                                       1f, 1f,    // Saturation
                                                       0.5f, 1f,  // Value
                                                       1f, 1f);   // Alpha
        rb.AddForce(Vector3.up * force);
    }
}
