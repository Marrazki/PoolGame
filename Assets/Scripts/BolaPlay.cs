using UnityEngine;

public class BolaPlay : MonoBehaviour
{
    public Menu menu;
    public GameObject gameManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseEnter()
    {
        menu.PlayGame();
    }
}
