using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Item : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public int ID;
    public Button Boton;
    public GameObject _descripcion;
    public Text Nombre_;
    public Text Dato_;
    public Vector3 offset;
    public DataBase DB;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Boton = GetComponent<Button>();
        _descripcion = Inventario.Descripcion;
        Nombre_ = _descripcion.transform.GetChild(0).GetComponent<Text>();
        Dato_ = _descripcion.transform.GetChild(1).GetComponent<Text>();
        _descripcion.SetActive(false);
        if (!_descripcion.GetComponent<Image>().enabled)
        {
            _descripcion.GetComponent<Image>().enabled = true;
            Nombre_.enabled = true;
            Dato_.enabled = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.parent.GetComponent<Image>() != null)
        { 
            transform.parent.GetComponent<Image>().fillCenter = true;
        }
        if (transform.parent == Inventario.canvas)
        { 
            _descripcion.SetActive (false);
        }
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        _descripcion.SetActive(true);
        Nombre_.text = DB.baseDatos[ID].nombre;
        Dato_.text = DB.baseDatos[ID].descripcion;
        _descripcion.transform.position = transform.position + offset;
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        _descripcion.SetActive(false);
    }
}
