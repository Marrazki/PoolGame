using Unity.Mathematics;
using UnityEngine;

public class DiamanteRebote : MonoBehaviour
{
    public GameManager gameManager;
    public InventarioBools inventarioBools;
    private void Awake()
    {
        gameManager = GameObject.FindGameObjectWithTag("GAMEMANAGER").GetComponent<GameManager>();
        inventarioBools = GameObject.FindGameObjectWithTag("INVENTARIOBOOLS").GetComponent<InventarioBools>();
    }
    public void VenderDiamanteRebote()
    {
        Debug.Log("VENTA");
        gameManager.dinero++;
        if (this.gameObject.transform.parent.name == inventarioBools.slot0.name)
        {
            Debug.Log("VENTA1");
            inventarioBools.slot[0] = false;
            inventarioBools.diamanteTiroRandom[0] = false;
            Debug.Log("VENTA2");
        }
        if (this.gameObject.transform.parent.name == inventarioBools.slot1.name)
        {
            inventarioBools.slot[1] = false;
            inventarioBools.diamanteRebote[1] = false;
        }
        if (this.gameObject.transform.parent.name == inventarioBools.slot2.name)
        {
            inventarioBools.slot[2] = false;
            inventarioBools.diamanteTiroRandom[2] = false;
        }
        if (this.gameObject.transform.parent.name == inventarioBools.slot3.name)
        {
            inventarioBools.slot[3] = false;
            inventarioBools.diamanteTiroRandom[3] = false;
        }
        if (this.gameObject.transform.parent.name == inventarioBools.slot4.name)
        {
            inventarioBools.slot[4] = false;
            inventarioBools.diamanteTiroRandom[4] = false;
        }
        if (this.gameObject.transform.parent.name == inventarioBools.slot5.name)
        {
            inventarioBools.slot[5] = false;
            inventarioBools.diamanteTiroRandom[5] = false;
        }
        Destroy(this.gameObject);
    }
}
