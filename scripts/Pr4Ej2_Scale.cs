using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pr4Ej2_Scale : MonoBehaviour
{
    Pr4Ej1_SphereManager sphereManager;
    // Start is called before the first frame update
    void Start()
    {
        sphereManager = GameObject.Find("SphereManager").GetComponent<Pr4Ej1_SphereManager>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector3(sphereManager.scale, sphereManager.scale, sphereManager.scale);
    }
}
