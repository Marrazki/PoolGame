using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    public Camera cam1;
    public Camera cam2;
    public GameObject taco;
    public GameObject bolaBlanca;
    float x;
    float z;
    public GameObject posBolaCamara;
    public float posBolaCamaraX;
    public float posBolaCamaraZ;
    // Start is called before the first frame update
    void Start()
    {
        cam1.enabled = true;
        cam2.enabled = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        x = taco.transform.position.x;
        z = taco.transform.position.z;
        transform.position = new Vector3(x, 7f, z);
        this.gameObject.transform.LookAt(bolaBlanca.transform);

        if (Input.GetKeyDown(KeyCode.Tab))  
        {
            cam1.enabled = !cam1.enabled; //cambia el bool de la camara 1
            cam2.enabled = !cam2.enabled; //cambia el bool de la camara 2
        }

        posBolaCamaraX = bolaBlanca.transform.position.x;
        posBolaCamaraZ = bolaBlanca.transform.position.z;
        posBolaCamara.transform.position = new Vector3(posBolaCamaraX, 4.5f, posBolaCamaraZ);
    }
}
