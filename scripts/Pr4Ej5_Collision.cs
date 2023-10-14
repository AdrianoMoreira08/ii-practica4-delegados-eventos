using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Pr4Ej5_Collision : MonoBehaviour
{
    public int points;
    TextMeshProUGUI textMesh;
    // Start is called before the first frame update
    void Start()
    {
        points = 0;
        textMesh = GameObject.Find("PointsDisplay").GetComponent<TextMeshProUGUI>();
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
        textMesh.text = "Points: " + points.ToString();
    }
}
