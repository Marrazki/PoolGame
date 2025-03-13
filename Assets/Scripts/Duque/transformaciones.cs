using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class transformaciones : MonoBehaviour
{
    public int velocidad;
    private int velocidadActual;
    public int VelocidadRotacion;
    void Start()
    {
        velocidadActual = velocidad;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            velocidadActual = velocidad * 2;
        }

        if (Input.GetKey(KeyCode.UpArrow))
            
        {
            this.gameObject.transform.Translate(Vector3.up * velocidadActual * Time.deltaTime);// mueve la Y en +1 * la velocidad asignada * el time delta time que hace que se igualen los fps en todos los dispositivos
            //this.gameObject.transform.Translate(new Vector3(0, 0.00001f, 0));// mueve la Y en +1
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.gameObject.transform.Translate(Vector3.down * velocidadActual * Time.deltaTime); // mueve la Y en -1
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.gameObject.transform.Translate(Vector3.left * velocidadActual * Time.deltaTime); // mueve la x en -1
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.gameObject.transform.Translate(Vector3.right * velocidadActual * Time.deltaTime); // mueve la x en +1
        }
        
        //ROTACION
        
        if (Input.GetKey(KeyCode.Q))
        {
            this.gameObject.transform.Rotate(Vector3.up * VelocidadRotacion * Time.deltaTime , Space.Self ); // rota la y en +1, con Space.Self es segun mi Y y con world con la real
        }
        if (Input.GetKey(KeyCode.E))
        {
            this.gameObject.transform.Rotate(Vector3.down * VelocidadRotacion * Time.deltaTime, Space.Self); // rota la y en -1
        }

    }
}
