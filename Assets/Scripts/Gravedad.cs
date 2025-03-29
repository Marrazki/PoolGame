using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravedad : MonoBehaviour
{
    public Rigidbody rb;
    public bool bolaQuieta = false;
    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (rb.linearVelocity.magnitude > 0)
        {
            if (rb.linearVelocity.magnitude < 0.5)
            {
                if (bolaQuieta == false)
                {
                    PararBola();
                    if (gameManager.tiros == 0)
                    {
                        gameManager.Perder();
                    }
                }
            }
        }
    }
    public void PararBola()
    {
        Debug.Log("PEIO PARAR BOLA");
        bolaQuieta = true;
        rb.linearVelocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
    }
}
