using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Randomizador : MonoBehaviour
{
    public BolasManager bolasManager;
    public GameManager gameManager;
    public Hoyo hoyo;
    public int randomBola;
    public float randomx;
    public float randomz;
    public GameObject bolaBlanca;
    AudioManager audioManager;
    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("AUDIO").GetComponent<AudioManager>();
    }
    // Start is called before the first frame update
    void Start()
    {
        Randomizar();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Randomizar();
        }
    }
    public void Randomizar()
    {
        gameManager.bolasEnLaMesa = gameManager.bolasQueCrear;
        Debug.Log("Bolas creada");
        for (int i = 0; i < gameManager.bolasEnLaMesa - 1; i++)
        { 
            randomx = Random.Range(-8, 9);
            randomz = Random.Range(-3, 4);
            randomBola = Random.Range(1, 15);
            if (randomBola == 8)//Quitar el número 8
            {
                randomBola++;
            }
            GameObject tiroTemporal = Instantiate(bolasManager.bolas[randomBola].gameObject, new Vector3(randomx, 5, randomz), bolaBlanca.transform.rotation) as GameObject;
            Rigidbody rb = tiroTemporal.GetComponent<Rigidbody>();
            audioManager.PlaySFX(audioManager.CrearBola);
        }
        //Bola negra
        {
            randomx = Random.Range(-8, 9);
            randomz = Random.Range(-3, 4);
            GameObject tiroTemporal = Instantiate(bolasManager.bolas[8].gameObject, new Vector3(randomx, 5, randomz), bolaBlanca.transform.rotation) as GameObject;
            Rigidbody rb = tiroTemporal.GetComponent<Rigidbody>();
        }
    }
}
