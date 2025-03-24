using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameManager gameManager;
    AudioManager audioManager;
    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("AUDIO").GetComponent<AudioManager>();
    }
    public void PlayGame()
    {
        audioManager.PlaySFX(audioManager.Click);
        SceneManager.LoadSceneAsync("PLAY");
        gameManager.SiguienteFase();
    }
    public void QuitGame()
    {
        audioManager.PlaySFX(audioManager.Click);
        Application.Quit();
    }
    public void Options()
    {
        audioManager.PlaySFX(audioManager.Click);
        SceneManager.LoadSceneAsync("OPTIONS");
    }
}
