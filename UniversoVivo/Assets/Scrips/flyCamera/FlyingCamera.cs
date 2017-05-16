using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class FlyingCamera : MonoBehaviour {

    public Transform CurrentPos, Mercurio, Venus, Tierra,Sol;
    public float timmer = 0;
    public float tiempoDemora = 3f;
    private float waitTime = 0f;
    private float wait = 0f;
    private float Volumen = 2.5f;

    private float contador = 0f;
    public int planet = 1;
    //private TrMer script;
    private int Mer = 1;
    private int Ven = 2;
    private int Tie = 3;
    private int Soll = 4;
    private int waith = 0;
    public AudioClip MerSound = null;
    public AudioClip VenSound = null;
    public AudioClip HolaSound = null;
    public AudioClip PistaSound = null;

    protected Transform Posicion = null;

    public mercurio SMer;
    public incorrecto SInc;

    public bool respondio=false;
    private int pista = -1;

    private bool Boolwait = false;
    private bool saludar = true;  // se usa una sola ves
    public bool RespCor=false;
    public bool RespInc=false;
    public bool gazeAt = false;

    void Start () {
        Posicion = transform;
        CurrentPos = Mercurio;

    }

    void Update()
    {
        //mercurio ScripMer = GetComponent<mercurio>();
        //incorrecto ScripInc = GetComponent<incorrecto>();
        //BoolMer = ScripMer.Ans;
        //BoolInc = ScripInc.Ans;
        //mercurio ScripMer = GetComponent<mercurio>();
        //incorrecto ScripInc = GetComponent<incorrecto>();

        if (respondio && waith<200)
        {
            waith++;
        }
        else {
            waith = 0;
            respondio = false;
        }
        if (planet>4)
        {
            planet = 1;
        }
        if (SMer.getAns() && !respondio)
        {
            Debug.Log("Ganaste!!!");
            planet++;
            respondio = true;

        }
        else if (SInc.getAns() && !respondio)
        {
            Debug.Log("Perdiste¡!!");
            respondio = true;
        }
        // preguntas Mercurio
        if (planet == Mer)
        {
            CurrentPos = Mercurio;
            timmer = 0;

            //saludar 
            if (!Boolwait && saludar)
            {
                AudioSource.PlayClipAtPoint(HolaSound, new Vector3(5, 1, 2), Volumen);
                saludar = false;
                Wait(1.2f);
            }else if (!Boolwait && pista != 1)
            {
                AudioSource.PlayClipAtPoint(MerSound, new Vector3(5, 1, 2), Volumen);
                //pista            
                pista = pista * -1;
                Wait(15);
            }
            if (!Boolwait && pista == 1)
            {
                AudioSource.PlayClipAtPoint(PistaSound, new Vector3(5, 1, 2), Volumen);
                pista = pista * -1;
                Wait(8);
            }
            
            //esperar

        }
        if (planet == Ven)
        {
            CurrentPos = Venus;
            timmer = 0;
            
            if (!Boolwait)
            {
                //pregunta
                AudioSource.PlayClipAtPoint(VenSound, new Vector3(5, 1, 2), Volumen);
            }
            Wait(15);
        }
        if (planet == Tie)
        {
            CurrentPos = Tierra;
            timmer = 0;
        }
        transform.localPosition = Vector3.Lerp(transform.localPosition, CurrentPos.position, 0.1f);
        transform.localRotation = Quaternion.Slerp(transform.localRotation, CurrentPos.rotation, 0.1f);
        ShoulIWait();

    }
    public void respIncEnter()
    {
        RespInc = true;
        gazeAt = true;
    }
    public void respIncExit()
    {
        RespInc = false;
        gazeAt = false;
    }
    
    public void Wait(float x)
    {
        waitTime = x;
        Boolwait = true;
    }
    public void ShoulIWait()
    {

        if (Boolwait && wait < waitTime)
        {
            wait += Time.deltaTime;
        }
        else
        {
            wait = 0f;
            waitTime = 0f;
            Boolwait = false;
        }
    }
    public void Wait2Sec(int time)
    {
        contador = 0;
        while (contador < 12f)
        {
            contador += Time.deltaTime;
        }


    }
    
}
