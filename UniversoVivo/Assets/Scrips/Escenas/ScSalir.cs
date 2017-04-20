using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScSalir : MonoBehaviour {
    public float gazetime = 5f;
    private float timer;
    private bool gazedAt;

    void Start()
    {

    }
    void Update()
    {
        GetComponent<Renderer>().material.color = gazedAt ? Color.cyan : Color.gray;
        if (gazedAt)
        {
            timer += Time.deltaTime;
            Debug.Log(timer);
            if (timer >= gazetime)
            {
                Application.Quit();
            }
        }
        else { timer = 0f; }
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
