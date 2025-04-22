using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Taco : MonoBehaviour
{
    [SerializeField] public GameObject bolaBlanca;
    float x;
    float z;
    private float velocidad = 0.5f;
    private float velocidadShift = 0.1f;
    private float velocidadActual;
    // Start is called before the first frame update
    void Start()
    {
        velocidadActual = velocidad;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            velocidadActual = velocidadShift;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            velocidadActual = velocidad;
        }
        x = bolaBlanca.transform.position.x;
        z = bolaBlanca.transform.position.z;
        transform.position = new Vector3(x, 4.62f, z);

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            this.gameObject.transform.Rotate(new Vector3(0, -1, 0) * velocidadActual); //Mover hacia la derecha
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            this.gameObject.transform.Rotate(new Vector3(0, 1, 0) * velocidadActual); //Mover hacia la izquierda
        }
    }
}
