using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScLugares : MonoBehaviour {
    public float gazetime = 3f;
    private float timer;
    private bool gazedAt;

    void Start()
    {

    }
    void Update()
    {
        GetComponent<Renderer>().material.color = gazedAt ? Color.cyan : Color.white;
        if (gazedAt)
        {
            timer += Time.deltaTime;
            //Debug.Log(timer);
            if (timer >= gazetime)
            {
                SceneManager.LoadScene("Lugares");
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
}