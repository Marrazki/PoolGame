using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuShop : MonoBehaviour
{
    AudioManager audioManager;
    private void Awake()
    {
        //audioManager = GameObject.FindGameObjectWithTag("AUDIO").GetComponent<AudioManager>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GoToPlay()
    {
        //audioManager.PlaySFX(audioManager.Click);
        SceneManager.LoadSceneAsync("PLAY");
    }
}
