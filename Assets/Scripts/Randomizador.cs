using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Randomizador : MonoBehaviour
{
    public static Randomizador Instance { get; private set; }
    public BolasManager bolasManager;
    public GameManager gameManager;
    public Hoyo hoyo;
    public int randomBola;
    public float randomx;
    public float randomz;
    public GameObject bolaBlanca;
    AudioManager audioManager;
    public float randomSHOP;
    public InventarioBools InventarioBools;
    [Header("DIAMANTES")]
    public GameObject imagenDiamanteAgujeroNegro;
    public GameObject imagenDiamanteBolaLisaMas10;
    public GameObject imagenDiamanteBolaRayadaMas10;
    public GameObject imagenDiamanteRebote;
    public GameObject imagenDiamanteTiroRandom;
    public GameObject imagenDiamanteX3MULT;
    [Header("MEJORAS")]
    public GameObject imagenMejoraTiros;
    public GameObject item1SHOP;
    public GameObject item2SHOP;
    public GameObject item3SHOP;
    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("AUDIO").GetComponent<AudioManager>();
        //Singleton
        if (Randomizador.Instance == null)
        {
            Randomizador.Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
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
            //Rigidbody rb = tiroTemporal.GetComponent<Rigidbody>();
            audioManager.PlaySFX(audioManager.CrearBola);
        }
        //Bola negra
        {
            randomx = Random.Range(-8, 9);
            randomz = Random.Range(-3, 4);
            GameObject tiroTemporal = Instantiate(bolasManager.bolas[8].gameObject, new Vector3(randomx, 5, randomz), bolaBlanca.transform.rotation) as GameObject;
            //Rigidbody rb = tiroTemporal.GetComponent<Rigidbody>();
            audioManager.PlaySFX(audioManager.CrearBola);
        }
    }
    public void RandomizarSHOP()
    {
        for (int i = 1; i < 4; i++)
        {
            randomSHOP = Random.Range(0, 7);

            if (i == 1)
            {
                if (randomSHOP == 0)
                {
                    imagenDiamanteAgujeroNegro.transform.position = item1SHOP.transform.position;
                }
                if (randomSHOP == 1)
                {
                    imagenDiamanteBolaLisaMas10.transform.position = item1SHOP.transform.position;
                }
                if (randomSHOP == 2)
                {
                    imagenDiamanteBolaLisaMas10.transform.position = item1SHOP.transform.position;
                }
                if (randomSHOP == 3)
                {
                    imagenDiamanteRebote.transform.position = item1SHOP.transform.position;
                }
                if (randomSHOP == 4)
                {
                    imagenDiamanteTiroRandom.transform.position = item1SHOP.transform.position;
                }
                if (randomSHOP == 5)
                {
                    imagenDiamanteX3MULT.transform.position = item1SHOP.transform.position;
                }
                if (randomSHOP == 6)
                {
                    imagenMejoraTiros.transform.position = item1SHOP.transform.position;
                }
            }
            if (i == 2)
            {
                if (randomSHOP == 0)
                {
                    imagenDiamanteAgujeroNegro.transform.position = item2SHOP.transform.position;
                }
                if (randomSHOP == 1)
                {
                    imagenDiamanteBolaLisaMas10.transform.position = item2SHOP.transform.position;
                }
                if (randomSHOP == 2)
                {
                    imagenDiamanteBolaRayadaMas10.transform.position = item2SHOP.transform.position;
                }
                if (randomSHOP == 3)
                {
                    imagenDiamanteRebote.transform.position = item2SHOP.transform.position;
                }
                if (randomSHOP == 4)
                {
                    imagenDiamanteTiroRandom.transform.position = item2SHOP.transform.position;
                }
                if (randomSHOP == 5)
                {
                    imagenDiamanteX3MULT.transform.position = item2SHOP.transform.position;
                }
                if (randomSHOP == 6)
                {
                    imagenMejoraTiros.transform.position = item2SHOP.transform.position;
                }
            }
            if (i == 3)
            {
                if (randomSHOP == 0)
                {
                    imagenDiamanteAgujeroNegro.transform.position = item3SHOP.transform.position;
                }
                if (randomSHOP == 1)
                {
                    imagenDiamanteBolaLisaMas10.transform.position = item3SHOP.transform.position;
                }
                if (randomSHOP == 2)
                {
                    imagenDiamanteBolaRayadaMas10.transform.position = item3SHOP.transform.position;
                }
                if (randomSHOP == 3)
                {
                    imagenDiamanteRebote.transform.position = item3SHOP.transform.position;
                }
                if (randomSHOP == 4)
                {
                    imagenDiamanteTiroRandom.transform.position = item3SHOP.transform.position;
                }
                if (randomSHOP == 5)
                {
                    imagenDiamanteX3MULT.transform.position = item3SHOP.transform.position;
                }
                if (randomSHOP == 6)
                {
                    imagenMejoraTiros.transform.position = item3SHOP.transform.position;
                }
            }
        }
    }
    public void OcultarItems()
    {
        imagenDiamanteAgujeroNegro.transform.localPosition = new Vector3(0, 1000, 0);
        imagenDiamanteBolaLisaMas10.transform.localPosition = new Vector3(0, 1000, 0);
        imagenDiamanteBolaRayadaMas10.transform.localPosition = new Vector3(0, 1000, 0);
        imagenDiamanteRebote.transform.localPosition = new Vector3(0, 1000, 0);
        imagenDiamanteTiroRandom.transform.localPosition = new Vector3(0, 1000, 0);
        imagenDiamanteX3MULT.transform.localPosition = new Vector3(0, 1000, 0);
        imagenMejoraTiros.transform.localPosition = new Vector3(0, 1000, 0);
    }
    public void CrearNegra()
    {
        //Bola negra
        {
            GameObject tiroTemporal = Instantiate(bolasManager.bolas[8].gameObject, new Vector3(0, 20, 0), bolaBlanca.transform.rotation) as GameObject;
            //Rigidbody rb = tiroTemporal.GetComponent<Rigidbody>();
            audioManager.PlaySFX(audioManager.CrearBola);
        }
    }
}
