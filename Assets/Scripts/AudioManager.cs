using Unity.VisualScripting;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance { get; private set; }
    [Header("---------- Audio Source ----------")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;
    [Header("---------- Audio Clip ----------")]
    public AudioClip background;
    //Play
    public AudioClip tiro;
    public AudioClip hoyo;
    public AudioClip CrearBola;
    public AudioClip choque;
    public AudioClip dinero;
    //Menú
    public AudioClip Click;

    private void Awake()
    {
        //Singleton
        if (AudioManager.Instance == null)
        {
            AudioManager.Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void Start()
    {
        musicSource.clip = background;
        musicSource.Play();
    }
    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }
}
