using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hoyo : MonoBehaviour
{
    public Gravedad gravedad;
    public GameManager gameManager;
    public GameObject bolaBlanca;
    public InventarioBools inventarioBools;
    public Randomizador randomizador;
    AudioManager audioManager;
    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("AUDIO").GetComponent<AudioManager>();
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void MeterBola(Bolas bola)
    {
        audioManager.PlaySFX(audioManager.hoyo);
        inventarioBools.UpdateTirosRandom();
        if (bola.numero == 8 || bola.numero == 0)
        {
            gameManager.puntuacion += gameManager.multiplicador * bola.numero;
            gameManager.puntuacionPorHoyo = gameManager.multiplicador * bola.numero;
            gameManager.multiplicador = gameManager.multiplicador * 2;
            if (bola.numero == 0)//Si es la blanca
            {
                gravedad.bolaQuieta = true;
                bolaBlanca.transform.position = new Vector3(8, 4.5f, 0);//Mover bolaBlanca a (8,4.5,0);
                gravedad.PararBola();
                gameManager.bolasMetidasPorTiro = 0;
                gameManager.multiplicador = 1;//Mult a X1
                if (gameManager.bolasEnLaMesa == 0)
                {
                    gravedad.PararBola();
                    gameManager.Shop();
                }
            }
            else if (bola.numero == 8)//Si es negra
            {
                if (gameManager.bolasEnLaMesa > 1)
                {
                    inventarioBools.UpdateAgujeroNegro();
                    if (inventarioBools.agujeroNegro == false)
                    {
                        gameManager.bolasEnLaMesa--;
                        gameManager.Perder();
                    }
                    else
                    {
                        inventarioBools.agujeroNegro = false;
                        randomizador.CrearNegra();
                    }
                }
                else if (gameManager.bolasEnLaMesa == 1)
                {
                    gravedad.PararBola();
                    gameManager.bolasMetidasPorTiro++;
                    gameManager.Shop();
                }
            }
        }
        else//Si no es ni negra ni blanca
        {
            gameManager.bolasEnLaMesa--;
            gameManager.bolasMetidasPorTiro++;
            if (bola.numero <= 0)
            {
                if (bola.tipo == false)//LISA
                {
                    gameManager.puntuacion += gameManager.multiplicador * (bola.numero + 10 * gameManager.bolaLisaNivel);
                    gameManager.puntuacionPorHoyo = (bola.numero + 10 * gameManager.bolaLisaNivel);
                    gameManager.multiplicador = gameManager.multiplicador * 2;
                    inventarioBools.UpdateBolasLisasPuntuacion();
                }
                if (bola.tipo == true)//RAYADA
                {
                    gameManager.puntuacion += gameManager.multiplicador * (bola.numero + 10 * gameManager.bolaRayadaNivel);
                    gameManager.multiplicador = gameManager.multiplicador * 2;
                    inventarioBools.UpdateBolasRayadasPuntuacion();
                }
            }
                if (bola.numero == -1)//DORADA
                {
                    gameManager.multiplicador = gameManager.multiplicador * 2;
                    gameManager.dineroPlus = true;
                    inventarioBools.UpdateBolasRayadasPuntuacion();
                }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        MeterBola(other.gameObject.GetComponent<Bolas>());
    }

}
