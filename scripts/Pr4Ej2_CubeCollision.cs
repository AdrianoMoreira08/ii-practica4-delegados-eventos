using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Pr4Ej2_CubeCollision : MonoBehaviour
{
    public delegate void mensaje();
    public event mensaje OnCubeCollisionWithGroup1;
    public event mensaje OnCubeCollisionNotWithGroup1;
    
    void OnCollisionEnter(Collision other) {
        switch (other.gameObject.tag) {
            case "Group1":
                OnCubeCollisionWithGroup1();
                break;
            default:
                OnCubeCollisionNotWithGroup1();
                break;
        }
    }
}
