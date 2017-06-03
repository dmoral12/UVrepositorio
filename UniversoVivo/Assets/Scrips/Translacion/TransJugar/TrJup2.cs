﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrJup2 : MonoBehaviour {
    public GameObject Sol;
    public GameObject Texto,sonido;
    private bool gazedAt;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (gazedAt)
        {
            Texto.SetActive(true);
            sonido.SetActive(true);
        }
        else
        {
            Texto.SetActive(false);
            sonido.SetActive(false);
            OrbitAround();
        }

    }
    void OrbitAround()
    {
        transform.RotateAround(Sol.transform.position, new Vector3(0f, 1f, 0f), -12 * Time.deltaTime);
    }
    public void PointerEnter()
    {
        gazedAt = true;
    }
    public void PointerExit()
    {
        gazedAt = false;
    }
}
