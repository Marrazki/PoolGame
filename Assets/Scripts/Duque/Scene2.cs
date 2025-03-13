using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(" El user del usuario es: " + PlayerPrefs.GetString("UserName"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
