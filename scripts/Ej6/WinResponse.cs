using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinResponse : MonoBehaviour
{
    Winning winning;
    // Start is called before the first frame update
    void Start()
    {
        winning = GameObject.Find("Final").GetComponent<Winning>();
        winning.OnWinning += StopMotion;
    }

    void StopMotion() {
        Destroy(GetComponent<MovementWASD>());
        Destroy(GetComponent<Rigidbody>());
    }
}
