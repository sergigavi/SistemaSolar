using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class planetas : MonoBehaviour
{
    public GameObject mercurio;
    public GameObject venus;
    public GameObject tierra;
    public GameObject marte;
    public GameObject jupiter;
    public GameObject saturno;
    public GameObject urano;
    public GameObject neptuno;

    public float escalaRotacion;
    public float escalaTraslacion;

    public GameObject centroSolEmpty;
    
    // Start is called before the first frame update
    void Start()
    {
        mercurio = GameObject.Find("MERCURIO");
        venus = GameObject.Find("VENUS");
        tierra = GameObject.Find("TIERRA");
        marte = GameObject.Find("MARTE");
        jupiter = GameObject.Find("JUPITER");
        saturno = GameObject.Find("SATURNO");
        urano = GameObject.Find("URANO");
        neptuno = GameObject.Find("NEPTUNO");

        escalaRotacion = 150000;
        escalaTraslacion = escalaRotacion/100000000;

        centroSolEmpty = GameObject.Find("scrEmptyPlanetas");
        
    }

    void Update()
    {
        rotacion();
        translacion();
    }

    public void rotacion()
    {
        mercurio.transform.Rotate(0, (float)(escalaRotacion * 0.000071839 * Time.deltaTime), 0);
        venus.transform.Rotate(0, (float)(escalaRotacion * 0.0000171467 * Time.deltaTime), 0);
        tierra.transform.Rotate(0, (float)(escalaRotacion * 0.004166666667 * Time.deltaTime), 0);
        marte.transform.Rotate(0, (float)(escalaRotacion * 0.0000060650169 * Time.deltaTime), 0);
        jupiter.transform.Rotate(0, (float)(escalaRotacion * 0.0100840336134454 * Time.deltaTime), 0);
        saturno.transform.Rotate(0, (float)(escalaRotacion * 0.0090909090909091 * Time.deltaTime), 0);
        urano.transform.Rotate(0, (float)(escalaRotacion * 0.0058027079303675 * Time.deltaTime), 0);
        neptuno.transform.Rotate(0, (float)(escalaRotacion * 0.0062630480167015 * Time.deltaTime), 0);
    }

    public void translacion()
    {
        mercurio.transform.RotateAround(centroSolEmpty.transform.position, Vector3.up, escalaTraslacion * 88 * Time.deltaTime);
        venus.transform.RotateAround(centroSolEmpty.transform.position, Vector3.up, escalaTraslacion * 225 * Time.deltaTime);
        tierra.transform.RotateAround(centroSolEmpty.transform.position, Vector3.up, escalaTraslacion * 365 * Time.deltaTime);
        marte.transform.RotateAround(centroSolEmpty.transform.position, Vector3.up, escalaTraslacion * (365 + 321) * Time.deltaTime);
        jupiter.transform.RotateAround(centroSolEmpty.transform.position, Vector3.up, escalaTraslacion * ((11*365)+314) * Time.deltaTime);
        saturno.transform.RotateAround(centroSolEmpty.transform.position, Vector3.up, escalaTraslacion * (30*365) * Time.deltaTime);
        urano.transform.RotateAround(centroSolEmpty.transform.position, Vector3.up, escalaTraslacion * (84*365) * Time.deltaTime);
        neptuno.transform.RotateAround(centroSolEmpty.transform.position, Vector3.up, escalaTraslacion * ((float)0.666) * Time.deltaTime);
    }


}
