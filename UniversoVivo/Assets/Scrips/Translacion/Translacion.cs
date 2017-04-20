using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Translacion : MonoBehaviour {
    public GameObject Tierra;
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
        transform.RotateAround(Tierra.transform.position, new Vector3(0f, 1f, 0f), -15 * Time.deltaTime);
    }
}