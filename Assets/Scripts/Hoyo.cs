using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hoyo : MonoBehaviour
{
    public Gravedad gravedad;
    public GameManager gameManager;
    public Bolas bolas;
    public GameObject bolaBlanca;
    public int bolasMetidasPorTiro;
    AudioManager audioManager;
    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("AUDIO").GetComponent<AudioManager>();
    }
    // Start is called before the first frame update
    void Start()
    {
        gameManager.fase = 1;
        gameManager.multiplicador = 1;
        bolasMetidasPorTiro = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Bolas metidas: " + bolasMetidasPorTiro);
    }
    public void MeterBola(Bolas bola)
    {
        audioManager.PlaySFX(audioManager.hoyo);
        gameManager.multiplicador = gameManager.multiplicador + bolasMetidasPorTiro;
        gameManager.puntuacion += gameManager.multiplicador * bola.numero;
        if (bola.numero == 0)//Si es la blanca
        {
            if (gameManager.bolasEnLaMesa > 0)
            {
                gravedad.bolaQuieta = true;
                bolaBlanca.transform.position = new Vector3(8, 4.5f, 0);//Mover bolaBlanca a (8,4.5,0);
                gravedad.PararBola();
                bolasMetidasPorTiro = 0;
                gameManager.multiplicador = 1;//Mult a X1
            }
            else if (gameManager.bolasEnLaMesa == 0)
            {
                gameManager.SiguienteFase();
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
                bolasMetidasPorTiro++;
                gameManager.SiguienteFase();
            }
        }
        else//Si no es ni negra ni blanca
        {
            gameManager.bolasEnLaMesa--;
            bolasMetidasPorTiro++;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        MeterBola(other.gameObject.GetComponent<Bolas>());
    }

}
