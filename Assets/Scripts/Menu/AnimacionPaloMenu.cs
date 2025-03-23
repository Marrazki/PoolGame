using Unity.VisualScripting;
using UnityEngine;

public class AnimacionPaloMenu : MonoBehaviour
{
    [SerializeField] public GameObject bolaQuit;
    [SerializeField] public GameObject bolaPlay;
    [SerializeField] public GameObject bolaOptions;
    float t;
    float x;
    float z;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void AnimationClickQuit()
    {
        x = Mathf.Lerp(0, bolaQuit.transform.position.x, t);
        z = Mathf.Lerp(-9, -7, t);
        transform.position = new Vector3(x, 0.5f, z);
        t += Time.deltaTime / 5;
    }
    public void AnimationClickPlay()
    {
        x = Mathf.Lerp(0, bolaPlay.transform.position.x, t);
        z = Mathf.Lerp(-9, -7, t);
        transform.position = new Vector3(x, 0.5f, z);
        t += Time.deltaTime / 5;
    }
    public void AnimationClickOptions()
    {
        x = Mathf.Lerp(0, bolaOptions.transform.position.x, t);
        z = Mathf.Lerp(-9, -7, t);
        transform.position = new Vector3(x, 0.5f, z);
        t += Time.deltaTime / 5;
    }
}
