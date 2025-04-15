using UnityEngine;
using UnityEngine.UI;

public class CartelEliminacion : MonoBehaviour
{
    [SerializeField]
    Inventario Inv;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Aceptar()
    {
        Inv.EliminarItem(Inv.OSID);
        Debug.Log("ACEPTAR");
        this.gameObject.SetActive(false);
    }
    public void Cancelar()
    {
        this.gameObject.SetActive(false);
    }
}
