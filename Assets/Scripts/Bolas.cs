using Unity.VisualScripting;
using UnityEngine;

public class Bolas : MonoBehaviour
{
    AudioManager audioManager;
    public int numero;
    public bool tipo;
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
        {
            audioManager.PlaySFX(audioManager.choque);
        }
    }
}