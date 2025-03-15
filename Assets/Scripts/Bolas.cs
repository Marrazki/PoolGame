using Unity.VisualScripting;
using UnityEngine;

public class Bolas : MonoBehaviour
{
    public int numero;
    public bool tipo;

    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}