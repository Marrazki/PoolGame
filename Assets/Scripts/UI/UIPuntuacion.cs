using TMPro;
using UnityEngine;

public class UIPuntuacion : MonoBehaviour
{
    public GameManager gameManager;
    public TextMeshProUGUI textoPuntuacion;

    // Update is called once per frame
    void Update()
    {
        textoPuntuacion.text = "Puntuacion: " + gameManager.puntuacion.ToString();
    }
}
