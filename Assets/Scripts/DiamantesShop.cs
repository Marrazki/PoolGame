using UnityEngine;

public class DiamantesShop : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject panel;
    private void Awake()
    {
        gameManager = GameObject.FindGameObjectWithTag("GAMEMANAGER").GetComponent<GameManager>();
    }
    public void ShowPanelShop()
    {
        panel.SetActive(true);
    }
    public void HidePanelShop()
    {
        panel.SetActive(false);
    }
}
