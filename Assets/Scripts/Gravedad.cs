using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravedad : MonoBehaviour
{
    public static Gravedad Instance { get; private set; }
    public Rigidbody rb;
    public bool bolaQuieta = false;
    public GameManager gameManager;
    public InventarioBools inventarioBools;
    private void Awake()
    {
        //Singleton
        if (Gravedad.Instance == null)
        {
            Gravedad.Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            //Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        gameManager.playing = true;
    }
    // Update is called once per frame
    void Update()
    {
        if (gameManager.playing)
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
    }
    public void PararBola()
    {
        Debug.Log("PEIO PARAR BOLA");
        bolaQuieta = true;
        rb.linearVelocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
    }
}
