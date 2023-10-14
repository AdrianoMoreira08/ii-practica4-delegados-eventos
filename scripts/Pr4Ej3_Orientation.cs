using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pr4Ej3_Orientation : MonoBehaviour
{
    Pr4Ej1_CubeCollision cubeCollision;
    Transform cylinder2;
    // Start is called before the first frame update
    void Start()
    {
        cylinder2 = GameObject.Find("Cylinder2").GetComponent<Transform>();
        cubeCollision = GameObject.Find("Cylinder").GetComponent<Pr4Ej1_CubeCollision>();
        cubeCollision.OnCubeCollision += FaceCylinder2;
    }

    void FaceCylinder2() {
        transform.LookAt(cylinder2.position, transform.up);
    }
}
