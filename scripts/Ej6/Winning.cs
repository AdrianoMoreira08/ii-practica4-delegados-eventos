using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Winning : MonoBehaviour
{
    
    public delegate void mensaje();
    public event mensaje OnWinning;
    
    void OnTriggerEnter(Collider other) {
        OnWinning();
    }
}
