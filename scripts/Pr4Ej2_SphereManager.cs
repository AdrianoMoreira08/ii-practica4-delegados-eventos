using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pr4Ej2_SphereManager : MonoBehaviour
{
    public float speed;
    public float scale;
    Pr4Ej1_CubeCollision cubeCollision;
    // Start is called before the first frame update
    void Start()
    {
        speed = 0f;
        scale = 1f;
        cubeCollision = GameObject.Find("Cylinder").GetComponent<Pr4Ej1_CubeCollision>();
        cubeCollision.OnCubeCollisionWithGroup1 += EnlargeGroup2;
        cubeCollision.OnCubeCollisionNotWithGroup1 += ChangeSpeed;
    }

    void EnlargeGroup2() {
        scale = 1.5f;
    }

    void ChangeSpeed() {
        speed = 6f;
    }
}
