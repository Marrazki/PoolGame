using TMPro;
using UnityEngine;

public class UITiros : MonoBehaviour
{
    public GameManager gameManager;
    public TextMeshProUGUI textoTiros;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textoTiros.text = "X " + gameManager.tiros.ToString();
    }
}
