using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FlyingCamera : MonoBehaviour {

    public Transform CurrentPos, Mercurio, Venus, Tierra, Marte, Jupiter, Saturno, Neptuno, Urano, Sol;

    public float timmer = 0;
    public float tiempoDemora = 3f;
    private float waitTime = 0f;
    private float wait = 0f;
    private float Volumen = 2.5f;
    private float contador = 0f;

    public int planet = 1;
    private int Mer = 1;
    private int Ven = 2;
    private int Tie = 3;
    private int Mar = 4;
    private int Jup = 5;
    private int Sat = 6;
    private int Nep = 7;
    private int Ura = 8;
    private int Soll = 9;
    private int waith = 0;
    private int tres = 3;

    public string Respuesta;

    protected Transform Posicion = null;

    public AScript A;
    public BScript B;
    public CScript C;

    public bool respondio=false;
    private int pista = -1;
    private int pista2 = -1;
    private int pista3 = -1;
    private int pista4 = -1;
    private int pista5 = -1;
    private int pista6 = -1;
    private int pista7 = -1;
    private int pista8 = -1;

    private bool Boolwait = false;
    private bool saludar = true;  // se usa una sola ves
    public bool RespCor=false;
    public bool RespInc=false;
    public bool gazeAt = false;
    private bool gano = false;

    public GameObject AuHola, Au1Pr, Au1Pi, Au2Pr, Au2Pi, Au3Pr, Au3Pi, Au4Pr, Au4Pi;
    public GameObject Au5Pr, Au5Pi, Au6Pr, Au6Pi, Au7Pr, Au7Pi, Au8Pr, Au8Pi;
    public GameObject A1,A2,A3,A4,A5,A6,A7,B1,B2,B3,B4,B5,B6,B7,C1,C2,C3,C4,C5,C6,C7;
    public GameObject perdiste,ganaste;

    void Start () {
        Posicion = transform;
        CurrentPos = Mercurio;
        perdiste.SetActive(false);
        ganaste.SetActive(false);
    }

    void Update()
    {

        if (respondio && waith<200)
        {
            waith++;
        }
        else {
            waith = 0;
            respondio = false;
        }
        if (planet>8)
        {
            planet = 1;
        }
        if (A.getAns() && !respondio)
        {
            Debug.Log("A!!!");
            Respuesta = "A";
            isItCorrect();
            respondio = true;
            
        }
        else if (B.getAns() && !respondio)
        {
            Debug.Log("B¡!!");
            Respuesta = "B";
            isItCorrect();
            respondio = true;
        }
        else if (C.getAns() && !respondio)
        {
            Debug.Log("C¡!!");
            Respuesta = "C";
            isItCorrect();
            respondio = true;
        }
        
        // preguntas Mercurio
        if (planet == Mer)
        {
            
            setRespFalse();
            A1.SetActive(true);
            B1.SetActive(true);
            C1.SetActive(true);

            CurrentPos = Mercurio;
            timmer = 0;

            //saludar 
            if (!Boolwait && saludar)
            {
                setAudFalse();
                AuHola.SetActive(true);
                saludar = false;
                Wait(1.2f);
            }else if (!Boolwait && pista != 1)
            {
                setAudFalse();
                Au1Pr.SetActive(true);

                //pista            
                pista = pista * -1;
                Wait(15);
            }
            if (!Boolwait && pista == 1)
            {
                setAudFalse();
                Au1Pi.SetActive(true);
                pista = pista * -1;
                Wait(8);
            }         
            //esperar
        }

        if (planet == Ven)
        {
            setRespFalse();
            A2.SetActive(true);
            B2.SetActive(true);
            C2.SetActive(true);
            CurrentPos = Venus;
            timmer = 0;
            
            if (!Boolwait && pista2 != 1)
            {
                //pregunta
                pista2 = pista2 * -1;
                setAudFalse();
                Au2Pr.SetActive(true);
                Wait(12);
            }
            if (!Boolwait && pista2 == 1)
            {
                //pista
                pista2 = pista2 * -1;
                setAudFalse();
                Au2Pi.SetActive(true);
                Wait(10);
            }
        }
        if (planet == Tie)
        {
            setRespFalse();
            A3.SetActive(true);
            B3.SetActive(true);
            C3.SetActive(true);
            CurrentPos = Tierra;
            timmer = 0;

            if (!Boolwait && pista3 != 1)
            {
                //pregunta
                pista3 = pista3 * -1;
                setAudFalse();
                Au3Pr.SetActive(true);
                Wait(12);
            }
            if (!Boolwait && pista3 == 1)
            {
                //pista
                pista3 = pista3 * -1;
                setAudFalse();
                Au3Pi.SetActive(true);
                Wait(10);
            }
        }
        if (planet == Mar)
        {
 
            setRespFalse();
            A4.SetActive(true);
            B4.SetActive(true);
            C4.SetActive(true);
            CurrentPos = Marte;
            timmer = 0;

            if (!Boolwait && pista4 != 1)
            {
                //pregunta
                pista4 = pista4 * -1;
                setAudFalse();
                Au4Pr.SetActive(true);
                Wait(12);
            }
            if (!Boolwait && pista4 == 1)
            {
                //pista
                pista4 = pista4 * -1;
                setAudFalse();
                Au4Pi.SetActive(true);
                Wait(10);
            }
        }
        if (planet == Jup)
        {

            setRespFalse();
            A5.SetActive(true);
            B5.SetActive(true);
            C5.SetActive(true);
            CurrentPos = Jupiter;
            timmer = 0;

            if (!Boolwait && pista5 != 1)
            {
                //pregunta
                pista5 = pista5 * -1;
                setAudFalse();
                Au5Pr.SetActive(true);
                Wait(12);
            }
            if (!Boolwait && pista5 == 1)
            {
                //pista
                pista5 = pista5 * -1;
                setAudFalse();
                Au5Pi.SetActive(true);
                Wait(10);
            }
        }
        if (planet == Sat)
        {

            setRespFalse();
            A6.SetActive(true);
            B6.SetActive(true);
            C6.SetActive(true);
            CurrentPos = Saturno;
            timmer = 0;

            if (!Boolwait && pista6 != 1)
            {
                //pregunta
                pista6 = pista6 * -1;
                setAudFalse();
                Au6Pr.SetActive(true);
                Wait(12);
            }
            if (!Boolwait && pista6 == 1)
            {
                //pista
                pista6 = pista6 * -1;
                setAudFalse();
                Au6Pi.SetActive(true);
                Wait(10);
            }
        }
        if (planet == Nep)
        {

            setRespFalse();
            A7.SetActive(true);
            B7.SetActive(true);
            C7.SetActive(true);
            CurrentPos = Neptuno;
            timmer = 0;

            if (!Boolwait && pista7 != 1)
            {
                //pregunta
                pista7 = pista7 * -1;
                setAudFalse();
                Au7Pr.SetActive(true);
                Wait(12);
            }
            if (!Boolwait && pista7 == 1)
            {
                //pista
                pista7 = pista7 * -1;
                setAudFalse();
                Au7Pi.SetActive(true);
                Wait(10);
            }
        }
        if (planet == Ura)
        {
            waitTime = waitTime + tres;
            tres = 0;
            ganaste.SetActive(true);
            gano = true;
            CurrentPos = Urano;
            timmer = 0;

            if (!Boolwait && pista8 != 1)
            {
                //pregunta
                pista8 = pista8 * -1;
                setAudFalse();
                Au8Pr.SetActive(true);
                Wait(4);
            }
            if (!Boolwait && pista8 == 1)
            {
                //pista
                pista8 = pista8 * -1;
                setAudFalse();
                Au8Pi.SetActive(true);
                Wait(4);
            }
        }
        ShoulIWait();
        if (!Boolwait && gano) {
            SceneManager.LoadScene("Menu");
        }
        transform.localPosition = Vector3.Lerp(transform.localPosition, CurrentPos.position, 0.1f);
        transform.localRotation = Quaternion.Slerp(transform.localRotation, CurrentPos.rotation, 0.1f);
 

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
        wait = 0f;
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
            perdiste.SetActive(false);
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
    public void setAudFalse() {
        AuHola.SetActive(false);
        Au1Pi.SetActive(false);
        Au1Pr.SetActive(false);
        Au2Pi.SetActive(false);
        Au2Pr.SetActive(false);
        Au3Pi.SetActive(false);
        Au3Pr.SetActive(false);
        Au4Pi.SetActive(false);
        Au4Pr.SetActive(false);
        Au5Pi.SetActive(false);
        Au5Pr.SetActive(false);
        Au6Pi.SetActive(false);
        Au6Pr.SetActive(false);
        Au7Pi.SetActive(false);
        Au7Pr.SetActive(false);
        Au8Pi.SetActive(false);
        Au8Pr.SetActive(false);
        
    }
    public void setRespFalse()
    {
        A1.SetActive(false);
        A2.SetActive(false);
        A3.SetActive(false);
        A4.SetActive(false);
        A5.SetActive(false);
        A6.SetActive(false);
        A7.SetActive(false);

        B1.SetActive(false);
        B2.SetActive(false);
        B3.SetActive(false);
        B4.SetActive(false);
        B5.SetActive(false);
        B6.SetActive(false);
        B7.SetActive(false);

        C1.SetActive(false);
        C2.SetActive(false);
        C3.SetActive(false);
        C4.SetActive(false);
        C5.SetActive(false);
        C6.SetActive(false);
        C7.SetActive(false);
    }
    public void isItCorrect() {
        if (Respuesta == "A" && planet == Mer)
        {
            planet++;
        }
        else if (Respuesta == "B" && planet == Ven)
        {
            planet++;
        }
        else if (Respuesta == "C" && planet == Tie)
        {
            planet++;
        }
        else if (Respuesta == "C" && planet == Mar)
        {
            planet++;
        }
        else if (Respuesta == "A" && planet == Jup)
        {
            planet++;
        }
        else if (Respuesta == "B" && planet == Sat)
        {
            planet++;
        }
        else if (Respuesta == "A" && planet == Nep)
        {
            planet++;
        }
        else if (Respuesta == "A" && planet == Ura)
        {
            planet++;
        }
        else {
            //Debug.Log("perdisssteeeeee!!!!!!");
            perdiste.SetActive(true);
            Wait(4);
        }
    }

}
