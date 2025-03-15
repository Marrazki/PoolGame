using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int tiros;
    public float fuerza;
    public int puntuacion;
    // Start is called before the first frame update
    void Start()
    {
        tiros = 10;
        fuerza = 2;
        puntuacion = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Perder()
    {
        Debug.Log("Has perdido");
    }
}
