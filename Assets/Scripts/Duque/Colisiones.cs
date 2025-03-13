using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisiones : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Debug.Log("Esfera clickada");
    }
    private void OnMouseOver()
    {
        Debug.Log("Estoy en la esfera");
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("He chocado con : " + collision.gameObject.name);
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Voy a pasar por : " + other.gameObject.name);
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Voy a salir de : " + other.gameObject.name);
    }
}
