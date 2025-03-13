using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
                    
                    /*GameObject tiroTemporal = Instantiate(tiroPrefab, tiroInicio.transform.position, tiroInicio.transform.rotation) as GameObject;
                    Rigidbody rb = tiroTemporal.GetComponent<Rigidbody>();
                    rb.AddForce(transform.forward * 1000 * fuerza);
                    Destroy(tiroTemporal, 0.3f);
                    Debug.Log("Tiro destruido");*/
                }
            }
        }
        //}
    }
}
