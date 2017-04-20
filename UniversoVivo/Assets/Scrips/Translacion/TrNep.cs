using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrNep : MonoBehaviour {
    public GameObject Sol;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        OrbitAround();

    }
    void OrbitAround()
    {
        transform.RotateAround(Sol.transform.position, new Vector3(0f, 1f, 0f), -8 * Time.deltaTime);
    }
}
