using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class panelControl : MonoBehaviour
{

    public planetas planetas;

    public GameObject btnPlay;
    public GameObject btnMenos;
    public GameObject btnMas;

        void Start()
    {
        btnPlay = GameObject.Find("btnPlay");
        btnMenos = GameObject.Find("btn-");
        btnMas = GameObject.Find("btn+");
    }

    public void aumentarVelocidad()
    {
        planetas = FindObjectOfType<planetas>();

        planetas.escalaRotacion = planetas.escalaRotacion + 60000;
        planetas.escalaTraslacion = planetas.escalaRotacion / 100000000;
    }

    public void disminuirVelocidad()
    {
        planetas = FindObjectOfType<planetas>();

        planetas.escalaRotacion = planetas.escalaRotacion - 60000;
        planetas.escalaTraslacion = planetas.escalaRotacion / 100000000;
    }

    public void pausarMovimientoPlanetas()
    {
        planetas = FindObjectOfType<planetas>();

        if (planetas.escalaRotacion == 0)
        {
            planetas.escalaRotacion = 150000;
            planetas.escalaTraslacion = planetas.escalaRotacion / 100000000;
        }
        else
        {
            planetas.escalaRotacion = 0;
            planetas.escalaTraslacion = 0;
        }
        
    }

    void Update()
    {
        
    }
}
