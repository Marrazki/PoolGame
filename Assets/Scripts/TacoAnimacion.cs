using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TacoAnimacion : MonoBehaviour
{
    public GameObject tiroAnimacionPrefab;
    public GameObject tiroAnimacionInicio;
    public Rigidbody tiroAnimacionRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject tiroTemporal = Instantiate(tiroAnimacionPrefab, tiroAnimacionInicio.transform.position, tiroAnimacionInicio.transform.rotation) as GameObject;
            Rigidbody rb = tiroTemporal.GetComponent<Rigidbody>();
            rb.AddForce(transform.forward * 10);
            Destroy(tiroTemporal, 0.05f);
        }
    }
}
