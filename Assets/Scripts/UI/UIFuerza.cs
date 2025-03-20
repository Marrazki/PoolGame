using TMPro;
using UnityEngine;

public class UIFuerza : MonoBehaviour
{
    public GameManager gameManager;
    public TextMeshProUGUI textoFuerza;

    // Update is called once per frame
    void Update()
    {
        textoFuerza.text = "Fuerza: " + gameManager.fuerza.ToString();
    }
}
