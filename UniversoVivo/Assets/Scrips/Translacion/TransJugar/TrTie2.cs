using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrTie2 : MonoBehaviour {
    public GameObject Sol,Texto;
    private bool gazedAt;

    void Start () {}

    void Update()
    {      
        if (gazedAt){
            Texto.SetActive(true);
        }
        else {
            Texto.SetActive(false);
            OrbitAround();
        }
    }
    void OrbitAround()
    {
        transform.RotateAround(Sol.transform.position, new Vector3(0f, 1f, 0f), -10 * Time.deltaTime);
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
        // Debug.Log("Poniter down");
    }
}
