using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
   

public class Dia4 : MonoBehaviour
{
    public Camera cam1;
    public Camera cam2;

    public GameObject musica;

    public string nombre;
   
    
    void Awake()
    {
        DontDestroyOnLoad(musica);
    }


    void Start()
    {
        cam1.enabled = true;
        cam2.enabled = false;
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            cam1.enabled = !cam1.enabled; //cambia el bool de la camara 1
            cam2.enabled = !cam2.enabled; //cambia el bool de la camara 2

        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            SceneManager.LoadScene(1);
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            PlayerPrefs.SetString("UserName", nombre);
        }
    }
}
