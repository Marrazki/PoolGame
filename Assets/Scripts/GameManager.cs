using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int tiros;
    public float fuerza;
    // Start is called before the first frame update
    void Start()
    {
        tiros = 10;
        fuerza = 2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void MeterBlanca()
    { 
        
    }
    void Perder()
    {
        Debug.Log("Has perdido");
    }
}
