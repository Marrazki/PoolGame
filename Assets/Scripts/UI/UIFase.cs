using TMPro;
using UnityEngine;

public class UIFase : MonoBehaviour
{
    public GameManager gameManager;
    public TextMeshProUGUI textoFase;
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
        textoFase.text = "FASE " + gameManager.fase.ToString();
    }
}
