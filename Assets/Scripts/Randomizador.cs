using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Randomizador : MonoBehaviour
{
    public int cantidadBolas = 1;
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
            Debug.Log("Bolas creada");
            for (int i = 0; i < cantidadBolas; i++)
            {
                GameObject tiroTemporal = Instantiate(bolaNegraPrefab, new Vector3(randomx, 5, randomz), bolaNegraPrefab.transform.rotation) as GameObject;
                Rigidbody rb = tiroTemporal.GetComponent<Rigidbody>();
                rb.AddForce(transform.forward * 0);
            }

        }
    }
    void Randomizar()
    {
        
        
            randomx = Random.Range(-8, 9);
            randomz = Random.Range(-3, 4);
    }
}
