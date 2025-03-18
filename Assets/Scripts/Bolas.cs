using Unity.VisualScripting;
using UnityEngine;

public class Bolas : MonoBehaviour
{
    public int numero;
    public bool tipo;

    void OnTriggerEnter(Collider other)
    {
        if (numero != 0)
        {
            Destroy(gameObject);
            Debug.Log("GOL");
        }
    }
}