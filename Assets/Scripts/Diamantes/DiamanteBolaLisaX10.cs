using Unity.Mathematics;
using UnityEngine;

public class DiamanteBolaLisaMas10 : MonoBehaviour
{
    public GameManager gameManager;
    public InventarioBools inventarioBools;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void VenderDiamanteBolaLisaMas10()
    {
        Debug.Log("VENTA");
        gameManager.dinero++;
        if (this.gameObject.transform.parent == inventarioBools.slot0)
        {
            Debug.Log("VENTA1");
            inventarioBools.slot[0] = false;
            inventarioBools.diamanteBolaLisaMas10[0] = false;
            Debug.Log("VENTA2");
        }
        if (this.gameObject.transform.parent == inventarioBools.slot1)
        {
            inventarioBools.slot[1] = false;
            inventarioBools.diamanteBolaLisaMas10[1] = false;
        }
        if (this.gameObject.transform.parent == inventarioBools.slot2)
        {
            inventarioBools.slot[2] = false;
            inventarioBools.diamanteBolaLisaMas10[2] = false;
        }
        if (this.gameObject.transform.parent == inventarioBools.slot3)
        {
            inventarioBools.slot[3] = false;
            inventarioBools.diamanteBolaLisaMas10[3] = false;
        }
        if (this.gameObject.transform.parent == inventarioBools.slot4)
        {
            inventarioBools.slot[4] = false;
            inventarioBools.diamanteBolaLisaMas10[4] = false;
        }
        if (this.gameObject.transform.parent == inventarioBools.slot5)
        {
            inventarioBools.slot[5] = false;
            inventarioBools.diamanteBolaLisaMas10[5] = false;
        }
    }
}
