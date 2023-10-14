using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pr4Ej4_Collision : MonoBehaviour
{
    public int points;
    // Start is called before the first frame update
    void Start()
    {
        points = 0;
    }

    void OnCollisionEnter(Collision other) {
        switch (other.gameObject.tag) {
            case "Group1":
                points += 5;
                Destroy(other.gameObject);
                break;
            case "Group2":
                points += 10;
                Destroy(other.gameObject);
                break;
        }

    }
    
    void Update() {
        Debug.Log("Points: " + points);
    }
}
