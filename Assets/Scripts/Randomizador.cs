using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Randomizador : MonoBehaviour
{
    public BolasManager bolasManager;
    public Bolas bolas;
    public Hoyo hoyo;
    public float randomBola;
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
        for (int i = 0; i < hoyo.bolasEnLaMesa - 1; i++)
        {//bolas[randomBola]
            GameObject tiroTemporal = Instantiate(bolaNegraPrefab, new Vector3(randomx, 5, randomz), bolaNegraPrefab.transform.rotation) as GameObject;
            Rigidbody rb = tiroTemporal.GetComponent<Rigidbody>();
        }
        //Bola negra
        {
            GameObject tiroTemporal = Instantiate(bolaNegraPrefab, new Vector3(randomx, 5, randomz), bolaNegraPrefab.transform.rotation) as GameObject;
            Rigidbody rb = tiroTemporal.GetComponent<Rigidbody>();
        }
    }
}
