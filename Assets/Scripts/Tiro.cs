using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Tiro : MonoBehaviour
{
    public Gravedad gravedad;
    public GameObject tiroPrefab;
    public GameObject tiroInicio;
    public Rigidbody tiroRigidbody;
    public Rigidbody bolaBlancaRb;
    public GameObject bolaBlanca;
    public Vector3 prevPos;
    public Vector3 currVel;
    public GameManager gameManager;
    public float friccion;
    void Start()
    {
        gameManager.tiros = 10;
        friccion = 1;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (gameManager.fuerza < 3) 
            {
                gameManager.fuerza = gameManager.fuerza + 0.5f;
                Debug.Log("Fuerza: " + gameManager.fuerza);
            }
        }
        if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (gameManager.fuerza > 0.5)
            {
                gameManager.fuerza = gameManager.fuerza - 0.5f;
                Debug.Log("Fuerza: " + gameManager.fuerza);
            }
        }
        if (gravedad.bolaQuieta == true)
        {
            if (gameManager.tiros >= 1)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    gameManager.tiros--;
                    Debug.Log(gameManager.tiros);
                    bolaBlancaRb.AddForce((bolaBlanca.transform.position - tiroInicio.transform.position).normalized * gameManager.fuerza * 500);
                    gravedad.bolaQuieta = false;

                }

            }
        }
        if (gravedad.bolaQuieta == false)
        {/*
            bolaBlancaRb.velocity = bolaBlancaRb.velocity * (1f - friccion * Time.fixedDeltaTime);
            if (bolaBlancaRb.velocity.magnitude < 0.1)
            {
                bolaBlancaRb.velocity = Vector3.zero;
            }*/
        }
    }
}
