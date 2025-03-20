using TMPro;
using UnityEngine;

public class UIFase : MonoBehaviour
{
    public GameManager gameManager;
    public TextMeshProUGUI textoFase;

    // Update is called once per frame
    void Update()
    {
        textoFase.text = "FASE " + gameManager.fase.ToString();
    }
}
