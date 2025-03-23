using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlphaTester1 : MonoBehaviour
{
    void OnGUI()
    {
        GetComponent<Image>().alphaHitTestMinimumThreshold = 0.5f;
    }
}