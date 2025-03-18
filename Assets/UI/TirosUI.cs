using UnityEngine;
using UnityEngine.UI;

public class TirosUI : MonoBehaviour
{
    public GameManager gameManager;
    public TMPro.TextMeshPro texto;
    // Update is called once per frame
    void Update()
    {
        texto.text = gameManager.tiros.ToString();
    }
}
