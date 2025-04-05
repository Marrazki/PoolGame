using UnityEngine;

public class Mejoras : MonoBehaviour
{
    AudioManager audioManager;
    public int precio;
    public string información;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("AUDIO").GetComponent<AudioManager>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
