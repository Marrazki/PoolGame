using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameManager gameManager;
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync("PLAY");
        gameManager.SiguienteFase();
    }
    public void QuitGame()
    { 
        Application.Quit();
    }
    public void Options()
    {
        
    }
}
