using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hoyo : MonoBehaviour
{
    public GameManager gameManager;
    public Bolas bolas;
    public int bolasEnLaMesa;
    public int multiplicador;
    public int fase;
    // Start is called before the first frame update
    void Start()
    {
        fase = 1;
        multiplicador = 1;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void MeterBola()
    {
        gameManager.puntuacion = gameManager.puntuacion + multiplicador * bolas.numero;
        if (bolasEnLaMesa > 0)
        {
            if (bolas.numero == 0)
            {
                //Mover bolaBlanca a (8,4.5,0);
                //Mult a X1
                multiplicador = 1;
            }
            if (bolas.numero == 8)
            {
                gameManager.Perder();
            }
            Debug.Log("PUNTUACIÓN: " + gameManager.puntuacion);
        }
        else if (bolasEnLaMesa == 0)
        {
            SiguienteFase();
        }
    }
    void SiguienteFase()
    {
        //Eliminar bolas
        //Instanciar Bolas
    }
    void OnTriggerEnter(Collider other)
    {
        bolas = other.gameObject.GetComponent<Bolas>();
        MeterBola();
        Debug.Log(bolas);
    }

}
