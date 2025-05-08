using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public Randomizador randomizador;
    public Hoyo hoyo;
    public Gravedad gravedad;
    public GameObject canvasUI;
    public GameObject canvasSHOP;
    public int tiros;
    public int tirosMax;
    public int tirosExtra;
    public float fuerza;
    public int puntuacion;
    public int puntuacionAnterior;
    public int puntuacionPorHoyo;
    public int bolasEnLaMesa;
    public int bolasQueCrear;
    public int multiplicador;
    public int fase;
    public bool playing;
    public int bolaLisaNivel;
    public int bolaRayadaNivel;
    public int bolasMetidasPorTiro;
    int naiara = 688821895;
    public int dinero = 0;
    public bool dineroPlus;
    private void Awake()
    {
        //Singleton
        if (GameManager.Instance == null)
        {
            GameManager.Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        tiros = 10;
        tirosMax = 10;
        fuerza = 2;
        puntuacion = 0;
        puntuacionPorHoyo = 0;
        bolaLisaNivel = 0;
        bolaRayadaNivel = 0;
        bolasEnLaMesa = 0;
        bolasQueCrear = 1;
        fase = 1;
        multiplicador = 1;
        bolasMetidasPorTiro = 0;
        dineroPlus = false;
        canvasUI.SetActive(true);
        canvasSHOP.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Perder()
    {
        Debug.Log("Has perdido");
        SceneManager.LoadSceneAsync("GAMEOVER");
        bolasQueCrear = 1;
        playing = false;
    }
    public void SiguienteFase()
    {
        PuntuacionATirosMax();
        canvasUI.SetActive(true);
        canvasSHOP.SetActive(false);
        Debug.Log("Siguiente Fase, fase " + fase);
        tiros = tirosMax + tirosExtra;
        tirosExtra = 0;
        bolasMetidasPorTiro = 0;
        multiplicador = 1;//Mult a X1
        fase++;
        bolasQueCrear++;
        randomizador.Randomizar();
        randomizador.OcultarItems();
    }
    public void Shop()
    {
        canvasUI.SetActive(false);
        canvasSHOP.SetActive(true);
        dinero += tiros + fase;
        if (dineroPlus)
        {
            dinero = +tiros + fase;
        }
        randomizador.RandomizarSHOP();
    }
    public void PuntuacionATirosMax()
    {
        for (int i = 1; i <= 16; i++)
        {
            if (puntuacion >= Math.Pow(10, i))
            {
                tirosExtra++;
            }
        }
    }
}
