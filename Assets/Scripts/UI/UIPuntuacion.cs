using TMPro;
using UnityEngine;

public class UIPuntuacion : MonoBehaviour
{
    public GameManager gameManager;
    public TextMeshProUGUI textoPuntuacion;
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
        textoPuntuacion.text = gameManager.puntuacion.ToString();
    }
}
