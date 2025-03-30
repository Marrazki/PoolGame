using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hoyo : MonoBehaviour
{
    public Gravedad gravedad;
    public GameManager gameManager;
    public GameObject bolaBlanca;
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
        gameManager.puntuacion += gameManager.multiplicador * bola.numero;
        gameManager.multiplicador = gameManager.multiplicador * 2;
        if (bola.numero == 0)//Si es la blanca
        {
            if (gameManager.bolasEnLaMesa > 0)
            {
                gravedad.bolaQuieta = true;
                bolaBlanca.transform.position = new Vector3(8, 4.5f, 0);//Mover bolaBlanca a (8,4.5,0);
                gravedad.PararBola();
                gameManager.bolasMetidasPorTiro = 0;
                gameManager.multiplicador = 1;//Mult a X1
            }
            else if (gameManager.bolasEnLaMesa == 0)
            {
                gravedad.PararBola();
                gameManager.Shop();
            }
        }
        else if (bola.numero == 8)//Si es negra
        {
            if (gameManager.bolasEnLaMesa > 1)
            {
                gameManager.bolasEnLaMesa--;
                gameManager.Perder();
            }
            else if (gameManager.bolasEnLaMesa == 1)
            {
                gravedad.PararBola();
                gameManager.bolasMetidasPorTiro++;
                gameManager.Shop();
            }
        }
        else//Si no es ni negra ni blanca
        {
            gameManager.bolasEnLaMesa--;
            gameManager.bolasMetidasPorTiro++;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        MeterBola(other.gameObject.GetComponent<Bolas>());
    }

}
