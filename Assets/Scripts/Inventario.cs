using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections.Generic;
using System;
using Unity.VisualScripting;

public class Inventario : MonoBehaviour
{
    public GraphicRaycaster graphRay;
    private PointerEventData pointerData;
    private List<RaycastResult> raycastResults;
    public Transform canvas;
    public GameObject objetoSeleccionado;
    public Transform exParent;
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
                    exParent = objetoSeleccionado.transform.parent.transform;
                    objetoSeleccionado.transform.SetParent(canvas);
                }
            }
        }
        if (objetoSeleccionado != null)
        {
            objetoSeleccionado.GetComponent<RectTransform>().localPosition = CanvasScreen(Input.mousePosition);
        }
        if (objetoSeleccionado != null)
        {
            if (Input.GetMouseButtonUp(0))
            {
                pointerData.position = Input.mousePosition;
                raycastResults.Clear();
                graphRay.Raycast(pointerData, raycastResults);
                if (raycastResults.Count > 0)
                {
                    bool nothingSelected = true;
                    foreach (var resultado in raycastResults)
                    {
                        if (resultado.gameObject.CompareTag("SlotDiamante"))
                        {
                            nothingSelected = false;
                            if (resultado.gameObject.GetComponentInChildren<Item>() == null)
                            {
                                objetoSeleccionado.transform.SetParent(resultado.gameObject.transform);
                                objetoSeleccionado.transform.localPosition = Vector2.zero;
                                exParent = objetoSeleccionado.transform.parent.transform;
                                Debug.Log("Slot Libre");
                            }
                            else
                            {
                                Debug.Log("Tienen distinto ID");

                                //  CAMBIAR DE SLOT ENTRE ELLOS

                                resultado.gameObject.transform.GetChild(0).SetParent(exParent);
                                objetoSeleccionado.transform.SetParent(resultado.gameObject.transform);
                                resultado.gameObject.transform.GetChild(0).localPosition = Vector2.zero;
                                exParent.gameObject.transform.GetChild(0).localPosition = Vector2.zero;

                                //  VOLVER AL SLOT DE ANTES

                                //objetoSeleccionado.transform.SetParent(exParent.transform);
                                //objetoSeleccionado.transform.localPosition = Vector2.zero;
                            }
                        }
                    }
                    if(nothingSelected)
                    {
                        objetoSeleccionado.transform.SetParent(exParent.transform);
                        objetoSeleccionado.transform.localPosition = Vector2.zero;
                    }
                }
                objetoSeleccionado = null;
            }
        }
        if (raycastResults != null)
        {
        raycastResults.Clear();
        }
    }
    public Vector2 CanvasScreen(Vector2 screenPos)
    {
        Vector2 viewportPoint = Camera.main.ScreenToViewportPoint(screenPos);
        Vector2 canvasSize = canvas.GetComponent<RectTransform>().sizeDelta;

        return (new Vector2(viewportPoint.x * canvasSize.x, viewportPoint.y * canvasSize.y) - (canvasSize / 2));
    }
}
