using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Pr4Ej3_CubeCollision : MonoBehaviour
{
    public delegate void mensaje();
    public event mensaje OnCubeCollision;
    
    void OnCollisionEnter(Collision other) {
        if (other.gameObject.name == "Cube") {
            OnCubeCollision();
        }
    }
}
