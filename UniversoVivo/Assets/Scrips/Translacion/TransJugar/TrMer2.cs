﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrMer2 : MonoBehaviour {
    public GameObject Sol,Texto,sonido;
    private bool gazedAt;
    // Use this for initialization
    void Start () {
		
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
            OrbitAround();
            sonido.SetActive(false);
        }
    }
    void OrbitAround()
    {
        transform.RotateAround(Sol.transform.position, new Vector3(0f, 1f, 0f), -20 * Time.deltaTime);
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
