using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Translacion2 : MonoBehaviour {

    public GameObject sphare;
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
        transform.RotateAround(sphare.transform.position, new Vector3(0f, 1f, 0f), 4 * Time.deltaTime);
    }
}
