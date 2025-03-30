using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Tiro : MonoBehaviour
{
    public GameManager gameManager;
    public Hoyo hoyo;
    public Gravedad gravedad;
    public GameObject tiroInicio;
    public Rigidbody bolaBlancaRb;
    public GameObject bolaBlanca;
    public Vector3 prevPos;
    public Vector3 currVel;
    AudioManager audioManager;
    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("AUDIO").GetComponent<AudioManager>();
    }
    void Start()
    {
        gameManager.tiros = 10;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (gameManager.fuerza < 3)
            {
                gameManager.fuerza = gameManager.fuerza + 0.5f;
            }
        }
        if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (gameManager.fuerza > 0.5)
            {
                gameManager.fuerza = gameManager.fuerza - 0.5f;
            }
        }
        if (gravedad.bolaQuieta == true)
        {
            if (gameManager.tiros >= 0)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    Debug.Log("PEIO TIRAR BOLA 1");
                    audioManager.PlaySFX(audioManager.tiro);
                    gameManager.tiros--;
                    bolaBlancaRb.AddForce((bolaBlanca.transform.position - tiroInicio.transform.position).normalized * gameManager.fuerza * 400);
                    gravedad.bolaQuieta = false;
                    Debug.Log("PEIO TIRAR BOLA 2");
                    if (gameManager.puntuacion == gameManager.puntuacionAnterior)
                    {
                        gameManager.multiplicador = 1;
                    }
                    gameManager.puntuacionAnterior = gameManager.puntuacion;
                    gameManager.bolasMetidasPorTiro = 0;
                    Debug.Log("PEIO TIRAR BOLA 3");
                }
            }
        }
    }
}
