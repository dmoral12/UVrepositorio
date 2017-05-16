using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class incorrecto : MonoBehaviour {
    private float timer;
    private bool gazedAt;
    private bool answer;
    private float gazetime = 3f;
    public bool Ans = false;

    void Start()
    {
        answer = false;
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
                Ans = true;
            }
        }
        else
        {
            Ans = false;
            timer = 0f;
        }
        GetComponent<Renderer>().material.color = gazedAt ? Color.red : Color.white;
    }
    public void PointerEnter()
    {
        gazedAt = true;
    }
    public void PointerExit()
    {
        gazedAt = false;
    }
    public bool getAns()
    {
        return Ans;
    }
    
}
