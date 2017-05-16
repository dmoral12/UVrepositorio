using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mercurio : MonoBehaviour {
    private float timer;
    private bool gazedAt;
    private bool answer1;
    private float gazetime = 3f;
    public bool Ans = false;

    void Start()
    {
        answer1 = false;
    }
    void Update()
    {
        GetComponent<Renderer>().material.color = gazedAt ? Color.red : Color.white;
        if (gazedAt)
        {
            timer += Time.deltaTime;
            //Debug.Log(timer);
            if (timer >= gazetime)
            {
                Ans = true;
            }
        }
        else {
            Ans = false;
            timer = 0f;
        }
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
