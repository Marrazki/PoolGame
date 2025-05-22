using Unity.Mathematics;
using UnityEngine;

public class DiamanteAgujeroNegro : MonoBehaviour
{
    public GameManager gameManager;
    public InventarioBools inventarioBools;
    private void Awake()
    {
        gameManager = GameObject.FindGameObjectWithTag("GAMEMANAGER").GetComponent<GameManager>();
        inventarioBools = GameObject.FindGameObjectWithTag("INVENTARIOBOOLS").GetComponent<InventarioBools>();        
    }
    public void VenderDiamanteAgujeroNegro()
    {
        Debug.Log("VENTA");
        gameManager.dinero++;
        Debug.Log(this.gameObject.transform.parent.name);
        Debug.Log(inventarioBools.slot0.name);
        if (this.gameObject.transform.parent.name == inventarioBools.slot0.name)
        {
            Debug.Log("VENTA1");
            inventarioBools.slot[0] = false;
            inventarioBools.diamanteAgujeroNegro[0] = false;
            Debug.Log("VENTA2");
        }
        if (this.gameObject.transform.parent.name == inventarioBools.slot1.name)
        {
            inventarioBools.slot[1] = false;
            inventarioBools.diamanteAgujeroNegro[1] = false;
        }
        if (this.gameObject.transform.parent.name == inventarioBools.slot2.name)
        {
            inventarioBools.slot[2] = false;
            inventarioBools.diamanteAgujeroNegro[2] = false;
        }
        if (this.gameObject.transform.parent.name == inventarioBools.slot3.name)
        {
            inventarioBools.slot[3] = false;
            inventarioBools.diamanteAgujeroNegro[3] = false;
        }
        if (this.gameObject.transform.parent.name == inventarioBools.slot4.name)
        {
            inventarioBools.slot[4] = false;
            inventarioBools.diamanteAgujeroNegro[4] = false;
        }
        if (this.gameObject.transform.parent.name == inventarioBools.slot5.name)
        {
            inventarioBools.slot[5] = false;
            inventarioBools.diamanteAgujeroNegro[5] = false;
        }
        Destroy(this.gameObject);
    }
}
