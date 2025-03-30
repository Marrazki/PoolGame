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
    public int tiros;
    public float fuerza;
    public int puntuacion;
    public int puntuacionAnterior;
    public int bolasEnLaMesa;
    public int bolasQueCrear;
    public int multiplicador;
    public int fase;
    public int bolasMetidasPorTiro;
    int naiara = 688821895;
    public int dinero = 0;
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
        fuerza = 2;
        puntuacion = 0;
        bolasEnLaMesa = 0;
        bolasQueCrear = 1;
        fase = 1;
        multiplicador = 1;
        bolasMetidasPorTiro = 0;
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
        tiros++;
    }
    public void SiguienteFase()
    {
        Debug.Log("Siguiente Fase, fase " + fase);
        tiros = 10;
        bolasMetidasPorTiro = 0;
        multiplicador = 1;//Mult a X1
        fase++;
        bolasQueCrear++;
        randomizador.Randomizar();
    }
    public void Shop()
    {
        SceneManager.LoadSceneAsync("SHOP");
        dinero += tiros;
    }
}
