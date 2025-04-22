using TMPro;
using UnityEngine;

public class UIPuntuacionPorHoyo : MonoBehaviour
{
    public GameManager gameManager;
    public TextMeshProUGUI textoPuntuacionPorHoyo;
    private void Awake()
    {
        GameObject manager = GameObject.FindGameObjectWithTag("GAMEMANAGER");
        if (manager != null)
        {
            gameManager = manager.GetComponent<GameManager>();
        }
        else
        {
            Debug.Log("NO LO HE ENCONTRADO");
        }
    }
    // Update is called once per frame
    void Update()
    {
        textoPuntuacionPorHoyo.text = gameManager.puntuacionPorHoyo.ToString();
    }
}
