﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bottonSd : MonoBehaviour {
    public AudioClip Sonido = null;
    public float Volumen = 1.0f;
    protected Transform Posicion = null;
    public GameObject Sound;

    // Use this for initialization
    void Start () {
      Posicion = transform;
        Sound.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        
	}
    public void PointerEnter()
    {
        AudioSource.PlayClipAtPoint(Sonido, new Vector3(5, 1, 2), Volumen);
        Sound.SetActive(false);
        Sound.SetActive(true);
    }
}
