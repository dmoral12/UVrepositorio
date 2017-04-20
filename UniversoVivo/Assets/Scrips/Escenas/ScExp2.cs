using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScExp2 : MonoBehaviour {
 
    private bool gazedAt;

    void Start()
    {

    }
    void Update()
    {
        

        if (gazedAt)
        {

            GetComponent<Renderer>().material.color = gazedAt ? Color.cyan : Color.gray; 
        }
        else {  }
    }
    public void PointerEnter()
    {
        gazedAt = true;
    }
    public void PointerExit()
    {
        gazedAt = false;
    }
    public void PointerDown()
    {
        Debug.Log("Poniter down");
    }
}