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

        if (bolaQuieta == false)
        {
            Debug.Log("velocidad: " + rb.linearVelocity.magnitude);
            Debug.Log("angular: " + rb.angularVelocity.magnitude);
            //rb.linearVelocity = rb.linearVelocity * 0.999f * Time.deltaTime;
            rb.angularVelocity = rb.angularVelocity * 0.999f; ;
            if (rb.linearVelocity.magnitude <= 1)
            {
                PararBola();
            }
        }
    }
    //rb.AddForce (new Vector3(0, 100 * gravedad * Time.deltaTime, 0));
void PararBola()
{
    rb.linearVelocity = Vector3.zero;
    rb.angularVelocity = Vector3.zero;
    bolaQuieta = true;

}
}
