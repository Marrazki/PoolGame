using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuOptions : MonoBehaviour
{
    AudioManager audioManager;
    public GameManager gameManager;
    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("AUDIO").GetComponent<AudioManager>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GoToMenu()
    {
        gameManager = GameObject.FindGameObjectWithTag("GAMEMANAGER").GetComponent<GameManager>();
        audioManager.PlaySFX(audioManager.Click);
        SceneManager.LoadSceneAsync("MENU");
        gameManager.StartPlay();
    }
}
