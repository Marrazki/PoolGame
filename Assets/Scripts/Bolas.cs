using Unity.VisualScripting;
using UnityEngine;

public class Bolas : MonoBehaviour
{
    public int numero;
    public bool tipo;
    AudioManager audioManager;
    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("AUDIO").GetComponent<AudioManager>();
    }
    void OnTriggerEnter(Collider other)
    {
        if (numero != 0)
        {
            Destroy(gameObject);
            Debug.Log("GOL");
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        //if collision TAG BOLA
        {
            audioManager.PlaySFX(audioManager.choque);
        }
    }
}