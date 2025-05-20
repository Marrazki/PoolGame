using Unity.Mathematics;
using UnityEngine;

public class DiamanteX3MULT : MonoBehaviour
{
    public GameManager gameManager;
    public InventarioBools inventarioBools;
    public void VenderDiamanteX3MULT()
    {
        Debug.Log("VENTA");
        gameManager.dinero++;
        if (this.gameObject.transform.parent == inventarioBools.slot0)
        {
            Debug.Log("VENTA1");
            inventarioBools.slot[0] = false;
            inventarioBools.diamanteX3MULT[0] = false;
            Debug.Log("VENTA2");
        }
        if (this.gameObject.transform.parent == inventarioBools.slot1)
        {
            inventarioBools.slot[1] = false;
            inventarioBools.diamanteX3MULT[1] = false;
        }
        if (this.gameObject.transform.parent == inventarioBools.slot2)
        {
            inventarioBools.slot[2] = false;
            inventarioBools.diamanteX3MULT[2] = false;
        }
        if (this.gameObject.transform.parent == inventarioBools.slot3)
        {
            inventarioBools.slot[3] = false;
            inventarioBools.diamanteX3MULT[3] = false;
        }
        if (this.gameObject.transform.parent == inventarioBools.slot4)
        {
            inventarioBools.slot[4] = false;
            inventarioBools.diamanteX3MULT[4] = false;
        }
        if (this.gameObject.transform.parent == inventarioBools.slot5)
        {
            inventarioBools.slot[5] = false;
            inventarioBools.diamanteX3MULT[5] = false;
        }
    }
}
