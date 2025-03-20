using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Randomizador randomizador;
    public Hoyo hoyo;
    public int tiros;
    public float fuerza;
    public int puntuacion;
    public int bolasEnLaMesa;
    public int bolasQueCrear;
    public int multiplicador;
    public int fase;
    // Start is called before the first frame update
    void Start()
    {
        tiros = 10;
        fuerza = 2;
        puntuacion = 0;
        bolasEnLaMesa = 0;
        bolasQueCrear = 1;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Perder()
    {
        Debug.Log("Has perdido");
        fase = 0;
        bolasQueCrear = 1;
    }
    public void SiguienteFase()
    {
        Debug.Log("Siguiente Fase, fase " + fase);
        tiros = 10;
        hoyo.bolasMetidasPorTiro = 0;
        multiplicador = 1;//Mult a X1
        fase++;
        bolasQueCrear++;
        randomizador.Randomizar();
    }
}
