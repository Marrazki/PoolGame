using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravedad : MonoBehaviour
{
    public Rigidbody rb;
    public float gravedad = -9.8f;
    public bool bolaQuieta = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            PararBola();
        }
    }
    //rb.AddForce (new Vector3(0, 100 * gravedad * Time.deltaTime, 0));
    public void PararBola()
    {
        rb.linearVelocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        bolaQuieta = true;
    }
}
