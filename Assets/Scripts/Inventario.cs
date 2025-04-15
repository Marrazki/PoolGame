using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections.Generic;
using System;
using Unity.VisualScripting;

public class Inventario : MonoBehaviour
{
    [System.Serializable]
    public struct ObjetoInvId
    {
        public int id;

        public ObjetoInvId(int id)
        {
            this.id = id;
        }
    }
    [SerializeField]
    DataBase data;
    [Header("Variables del Drag and Drop")]
    public GraphicRaycaster graphRay;
    private PointerEventData pointerData;
    private List<RaycastResult> raycastResults;
    public static Transform canvas;
    public GameObject objetoSeleccionado;
    public Transform exParent;
    [Header("Prefs e Items")]
    ////////
    public static GameObject Descripcion;
    //public CartelEliminacion CE;
    public int OSC;
    public int OSID;
    ////////
    public Transform contenido;
    public Item item;
    public List<ObjetoInvId> inventario = new List<ObjetoInvId>();
    void Start()
    {
        pointerData = new PointerEventData(null);
        raycastResults = new List<RaycastResult>();

        Descripcion = GameObject.Find("Descripcion");

        //CE.gameObject.SetActive(false);

        canvas = transform.parent.transform;
    }
    void Update()
    {
        Arrastrar();
    }
    void Arrastrar()
    {
        if (Input.GetMouseButtonDown(1))
        {
            pointerData.position = Input.mousePosition;
            graphRay.Raycast(pointerData, raycastResults);
            if (raycastResults.Count > 0)
            {
                if (raycastResults[0].gameObject.GetComponent<Item>())
                {
                    objetoSeleccionado = raycastResults[0].gameObject;
                    ///////////
                    OSID = objetoSeleccionado.GetComponent<Item>().ID;
                    ///////////
                    exParent = objetoSeleccionado.transform.parent.transform;
                    exParent.GetComponent<Image>().fillCenter = false;
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
            if (Input.GetMouseButtonUp(1))
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
                            if (resultado.gameObject.CompareTag("Eliminar"))
                            {
                                //CE.gameObject.SetActive(false);
                                EliminarItem(objetoSeleccionado.gameObject.GetComponent<Item>().ID);
                            }
                        }
                    }
                    if (nothingSelected)
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
    public void AgregarItem(int id)
    {
        inventario.Add(new ObjetoInvId(id));
        InventoryUpdate();
    }
    public void EliminarItem(int id)
    {
        for (int i = 0; i < inventario.Count; i++)
        {
            inventario.Remove(inventario[i]);
            InventoryUpdate();
        }
    }
    List<Item> pool = new List<Item>();
    public void InventoryUpdate()
    {
        for (int i = 0; i < pool.Count; i++)
        {
            if (i < inventario.Count)
            {
                ObjetoInvId o = inventario[i];
                pool[i].ID = o.id;
                pool[i].GetComponent<Image>().sprite = data.baseDatos[o.id].icono;
                pool[i].GetComponent<RectTransform>().localPosition = Vector3.zero;
                pool[i].Boton.onClick.RemoveAllListeners();
                pool[i].Boton.onClick.AddListener(() => gameObject.SendMessage(data.baseDatos[o.id].Void, SendMessageOptions.DontRequireReceiver));
                pool[i].gameObject.SetActive(true);
            }
            else
            {
                pool[i].gameObject.SetActive(false);
                pool[i]._descripcion.SetActive(false);
                pool[i].gameObject.transform.parent.GetComponent<Image>().fillCenter = false;
            }
        }
        if (inventario.Count > pool.Count)
        {
            for (int i = pool.Count; i < inventario.Count; i++)
            {
                Item it = Instantiate(item, contenido.GetChild(i));
                pool.Add(it);

                if (contenido.GetChild(0).childCount >= 2)
                {
                    for (int s = 0; s < contenido.childCount; s++)
                    {
                        if (contenido.GetChild(s).childCount == 0)
                        {
                            it.transform.SetParent(contenido.GetChild(s));
                            break;
                        }
                    }
                }
                it.transform.position = Vector3.zero;
                it.transform.localScale = Vector3.one;

                ObjetoInvId o = inventario[i];
                pool[i].ID = o.id;
                pool[i].GetComponent<RectTransform>().localPosition = Vector3.zero;
                pool[i].GetComponent<Image>().sprite = data.baseDatos[o.id].icono;
                pool[i].Boton.onClick.RemoveAllListeners();
                pool[i].Boton.onClick.AddListener(() => gameObject.SendMessage(data.baseDatos[o.id].Void, SendMessageOptions.DontRequireReceiver)); pool[i].gameObject.SetActive(true);
            }
        }
    }
}
