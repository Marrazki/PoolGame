using Unity.VisualScripting;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
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
    //Menú
    public AudioClip Click;

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
