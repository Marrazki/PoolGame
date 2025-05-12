using TMPro;
using UnityEngine;

public class Diamantes : MonoBehaviour
{
    AudioManager audioManager;
    public GameManager gameManager;
    public int precio;
    public string nombre;
    public string información;
    public GameObject panel;

    private void Awake()
    {
      //  audioManager = GameObject.FindGameObjectWithTag("AUDIO").GetComponent<AudioManager>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ShowPanel()
    {
        panel.SetActive(true);
    }
    public void HidePanel()
    {
        panel.SetActive(false);
    }
    public void Vender()
    { 
        Destroy(this.gameObject);
        gameManager.dinero++;
    }
}
