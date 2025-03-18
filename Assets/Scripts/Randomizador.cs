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
    public GameObject bolaNegraPrefab;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Randomizar();
        }
    }
    void Randomizar()
    {
        //Quitando el número 8
        randomBola = Random.Range(1, 15);
        randomx = Random.Range(-8, 9);
        randomz = Random.Range(-3, 4);
        Debug.Log("Bolas creada");
        for (int i = 0; i < gameManager.bolasEnLaMesa - 1; i++)
        {//bolas[randomBola]
            GameObject tiroTemporal = Instantiate(bolasManager.bolas[randomBola].gameObject, new Vector3(randomx, 5, randomz), bolaNegraPrefab.transform.rotation) as GameObject;
            Rigidbody rb = tiroTemporal.GetComponent<Rigidbody>();
            gameManager.bolasEnLaMesa++;
        }
        //Bola negra
        {
            GameObject tiroTemporal = Instantiate(bolasManager.bolas[8].gameObject, new Vector3(randomx, 5, randomz), bolaNegraPrefab.transform.rotation) as GameObject;
            Rigidbody rb = tiroTemporal.GetComponent<Rigidbody>();
            gameManager.bolasEnLaMesa++;
        }
    }
}
