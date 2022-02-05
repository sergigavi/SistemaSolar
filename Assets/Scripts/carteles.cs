using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class carteles : MonoBehaviour
{

    public GameObject emptyMe;

    public GameObject mercuriotxt;
    public GameObject venustxt;
    public GameObject tierratxt;
    public GameObject martetxt;
    public GameObject jupitertxt;
    public GameObject saturnotxt;
    public GameObject uranotxt;
    public GameObject neptunotxt;

    void Start()
    {
        emptyMe = GameObject.Find("emptyMe");

        mercuriotxt = GameObject.Find("txtMercurio");
        venustxt = GameObject.Find("txtVenus");
        tierratxt = GameObject.Find("txtTierra");
        martetxt = GameObject.Find("txtMarte");
        jupitertxt = GameObject.Find("txtJupiter");
        saturnotxt = GameObject.Find("txtSaturno");
        uranotxt = GameObject.Find("txtUrano");
        neptunotxt = GameObject.Find("txtNeptuno");

    }

    void Update()
    {
        mirarACam();
    }

    private void mirarACam()
    {
        mercuriotxt.transform.LookAt(emptyMe.transform);
        venustxt.transform.LookAt(emptyMe.transform);
        tierratxt.transform.LookAt(emptyMe.transform);
        martetxt.transform.LookAt(emptyMe.transform);
        jupitertxt.transform.LookAt(emptyMe.transform);
        saturnotxt.transform.LookAt(emptyMe.transform);
        uranotxt.transform.LookAt(emptyMe.transform);
        neptunotxt.transform.LookAt(emptyMe.transform);
    }
}
