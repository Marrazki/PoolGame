using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hoyo : MonoBehaviour
{
    public GameManager gameManager;
    public Bolas bolas;
    public GameObject bolaBlanca;
    // Start is called before the first frame update
    void Start()
    {
        gameManager.fase = 1;
        gameManager.multiplicador = 1;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void MeterBola(Bolas bola)
    {
        gameManager.puntuacion = gameManager.puntuacion + gameManager.multiplicador * bola.numero;
        if (bola.numero == 0)//Si es la blanca
        {
            if (gameManager.bolasEnLaMesa > 0)
            {
                bolaBlanca.transform.position = new Vector3(8, 4.5f, 0);//Mover bolaBlanca a (8,4.5,0);
                gameManager.multiplicador = 1;//Mult a X1
            }        
            else if (gameManager.bolasEnLaMesa == 0)
        {
                gameManager.SiguienteFase();
        }
        }
        if (bola.numero == 8)//Si es negra
        {
            if (gameManager.bolasEnLaMesa > 1)
            {
                gameManager.Perder();
            }
            else if (gameManager.bolasEnLaMesa == 1)
            {
                gameManager.SiguienteFase();
            }

        }
        Debug.Log("PUNTUACIÓN: " + gameManager.puntuacion);



    }
    
    void OnTriggerEnter(Collider other)
    {
        MeterBola(other.gameObject.GetComponent<Bolas>());
    }

}
