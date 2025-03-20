using TMPro;
using UnityEngine;

public class UIMultiplicador : MonoBehaviour
{
    public GameManager gameManager;
    public TextMeshProUGUI textoMultiplicador;

    // Update is called once per frame
    void Update()
    {
        textoMultiplicador.text = "X" + gameManager.multiplicador.ToString();
    }
}
