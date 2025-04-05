using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections.Generic;

public class Inventario : MonoBehaviour
{
    public GraphicRaycaster graphRay;
    private PointerEventData pointerData;
    private List<RaycastResult> raycastResults;
    public Transform canvas;
    public GameObject objetoSeleccionado;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pointerData = new PointerEventData(null);
        raycastResults = new List<RaycastResult>();

    }

    // Update is called once per frame
    void Update()
    {
        Arrastrar();
    }
    void Arrastrar()
    {
        if (Input.GetMouseButtonDown(0))
        { 
            pointerData.position = Input.mousePosition;
            graphRay.Raycast(pointerData, raycastResults);
            if (raycastResults.Count > 0)
            {
                if (raycastResults[0].gameObject.GetComponent<Item>())
                { 
                    objetoSeleccionado = raycastResults[0].gameObject;
                    objetoSeleccionado.transform.SetParent(canvas);
                }
            }
        }
        if (Input.GetMouseButtonUp(0))
        {
            pointerData.position = Input.mousePosition;
            raycastResults.Clear();
            graphRay.Raycast(pointerData, raycastResults);
            if (raycastResults.Count > 0)
            {
                foreach (var resultado in raycastResults)
                {
                    if (resultado.gameObject.tag == "SlotDiamante")
                    {
                        objetoSeleccionado.transform.SetParent(resultado.gameObject.transform);
                        objetoSeleccionado.transform.localPosition = Vector2.zero;
                    }
                }
            }
            objetoSeleccionado = null;
        }
        raycastResults.Clear();
    }
}
