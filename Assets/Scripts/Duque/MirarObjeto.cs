using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirarObjeto : MonoBehaviour
{
    public GameObject objetivo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.LookAt(objetivo.transform);
    }
}
