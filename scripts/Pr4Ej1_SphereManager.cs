using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pr4Ej1_SphereManager : MonoBehaviour
{
    public float speed;
    Pr4Ej1_CubeCollision cubeCollision;
    List<Material> group1_material;
    // Start is called before the first frame update
    void Start()
    {
        group1_material = new List<Material>();
        speed = 0f;
        cubeCollision = GameObject.Find("Cylinder").GetComponent<Pr4Ej1_CubeCollision>();
        GameObject[] group1 = GameObject.FindGameObjectsWithTag("Group1");
        foreach (GameObject sphere in group1) {
            group1_material.Add(sphere.GetComponent<Renderer>().material);
        }
        cubeCollision.OnCubeCollision += ChangeGroup1Color;
        cubeCollision.OnCubeCollision += ChangeSpeed;
    }

    void ChangeGroup1Color() {
        foreach (Material sphere_mat in group1_material) {
            sphere_mat.color = Random.ColorHSV(0f, 1f,    // Hue
                                               1f, 1f,    // Saturation
                                               0.5f, 1f,  // Value
                                               1f, 1f);   // Alpha
        }
    }

    void ChangeSpeed() {
        speed = 10f;
    }
}
