using UnityEngine;

public class SHOPManager : MonoBehaviour
{
    public GameManager gameManager;
    public InventarioBools inventarioBools;
    public Randomizador randomizador;

    public int precioDiamanteAgujeroNegro = 15;
    public int precioDiamanteBolaLisaX10 = 7;
    public int precioDiamanteBolaRayadaX10 = 7;
    public int precioDiamanteRebote = 10;
    public int precioDiamanteTiroRandom = 8;
    public int precioDiamanteX3MULT = 13;
    [Header("PREFABS")]
    public GameObject prefabDiamanteAgujeroNegro;
    public GameObject prefabDiamanteBolaLisaX10;
    public GameObject prefabDiamanteBolaRayadaX10;
    public GameObject prefabDiamanteRebote;
    public GameObject prefabDiamanteTiroRandom;
    public GameObject prefabDiamanteX3MULT;


    public void ComprarDiamanteAgujeroNegro()
    {
        if (gameManager.dinero >= precioDiamanteAgujeroNegro)
        {
            for (int i = 0; i < 7; i++)
            {
                if (inventarioBools.slot[i] == false)
                {
                    gameManager.dinero = gameManager.dinero - precioDiamanteAgujeroNegro;
                    inventarioBools.diamanteAgujeroNegro[i] = true;
                    inventarioBools.slot[i] = true;
                    GameObject diamanteTemp = Instantiate(prefabDiamanteAgujeroNegro.gameObject, new Vector3(0, 0, 0), new Quaternion(0f, 0f, 0f, 1f)) as GameObject;
                    diamanteTemp.transform.parent = inventarioBools.transform;
                    randomizador.imagenDiamanteAgujeroNegro.transform.localPosition = new Vector3(0, 1000, 0);
                    diamanteTemp.transform.localPosition = new Vector3(-500 + 200 * i, 350, 0);
                    return;
                }
            }

        }
    }
    public void ComprarDiamanteBolaLisaX10()
    {
        if (gameManager.dinero >= precioDiamanteBolaLisaX10)
        {
            for (int i = 0; i < 7; i++)
            {
                if (inventarioBools.slot[i] == false)
                {
                    gameManager.dinero = gameManager.dinero - precioDiamanteBolaLisaX10;
                    inventarioBools.diamanteBolaLisaX10[i] = true;
                    inventarioBools.slot[i] = true;
                    GameObject diamanteTemp = Instantiate(prefabDiamanteBolaLisaX10.gameObject, new Vector3(0, 0, 0), new Quaternion(0f, 0f, 0f, 1f)) as GameObject;
                    diamanteTemp.transform.parent = inventarioBools.transform;
                    randomizador.imagenDiamanteBolaLisaX10.transform.localPosition = new Vector3(0, 1000, 0);
                    diamanteTemp.transform.localPosition = new Vector3(-500 + 200 * i, 350, 0);
                    return;
                }
            }
        }
    }
    public void ComprarDiamanteBolaRayadaX10()
    {
        if (gameManager.dinero >= precioDiamanteBolaRayadaX10)
        {
            for (int i = 0; i < 7; i++)
            {
                if (inventarioBools.slot[i] == false)
                {
                    gameManager.dinero = gameManager.dinero - precioDiamanteBolaRayadaX10;
                    inventarioBools.diamanteBolaRayadaX10[i] = true;
                    inventarioBools.slot[i] = true;
                    GameObject diamanteTemp = Instantiate(prefabDiamanteBolaRayadaX10.gameObject, new Vector3(0, 0, 0), new Quaternion(0f, 0f, 0f, 1f)) as GameObject;
                    diamanteTemp.transform.parent = inventarioBools.transform;
                    randomizador.imagenDiamanteBolaRayadaX10.transform.localPosition = new Vector3(0, 1000, 0);
                    diamanteTemp.transform.localPosition = new Vector3(-500 + 200 * i, 350, 0);
                    return;
                }
            }
        }
    }
    public void ComprarDiamanteRebote()
    {
        if (gameManager.dinero >= precioDiamanteRebote)
        {
            for (int i = 0; i < 7; i++)
            {
                if (inventarioBools.slot[i] == false)
                {
                    gameManager.dinero = gameManager.dinero - precioDiamanteRebote;
                    inventarioBools.diamanteRebote[i] = true;
                    inventarioBools.slot[i] = true;
                    GameObject diamanteTemp = Instantiate(prefabDiamanteRebote.gameObject, new Vector3(0, 0, 0), new Quaternion(0f, 0f, 0f, 1f)) as GameObject;
                    diamanteTemp.transform.parent = inventarioBools.transform;
                    randomizador.imagenDiamanteRebote.transform.localPosition = new Vector3(0, 1000, 0);
                    diamanteTemp.transform.localPosition = new Vector3(-500 + 200 * i, 350, 0);
                    return;
                }
            }
        }
    }
    public void ComprarDiamanteTiroRandom()
    {
        if (gameManager.dinero >= precioDiamanteTiroRandom)
        {
            for (int i = 0; i < 7; i++)
            {
                if (inventarioBools.slot[i] == false)
                {
                    gameManager.dinero = gameManager.dinero - precioDiamanteTiroRandom;
                    inventarioBools.diamanteTiroRandom[i] = true;
                    inventarioBools.slot[i] = true;
                    GameObject diamanteTemp = Instantiate(prefabDiamanteTiroRandom.gameObject, new Vector3(0, 0, 0), new Quaternion(0f, 0f, 0f, 1f)) as GameObject;
                    diamanteTemp.transform.parent = inventarioBools.transform;
                    randomizador.imagenDiamanteTiroRandom.transform.localPosition = new Vector3(0, 1000, 0);
                    diamanteTemp.transform.localPosition = new Vector3(-500 + 200 * i, 350, 0);
                    return;
                }
            }
        }
    }
    public void ComprarDiamanteX3MULT()
    {
        if (gameManager.dinero >= precioDiamanteX3MULT)
        {
            for (int i = 0; i < 7; i++)
            {
                if (inventarioBools.slot[i] == false)
                {
                    gameManager.dinero = gameManager.dinero - precioDiamanteX3MULT;
                    inventarioBools.diamanteX3MULT[i] = true;
                    inventarioBools.slot[i] = true;
                    GameObject diamanteTemp = Instantiate(prefabDiamanteX3MULT.gameObject, new Vector3(0, 0, 0), new Quaternion(0f, 0f, 0f, 1f)) as GameObject;
                    diamanteTemp.transform.parent = inventarioBools.transform;
                    randomizador.imagenDiamanteX3MULT.transform.localPosition = new Vector3(0, 1000, 0);
                    diamanteTemp.transform.localPosition = new Vector3(-500 + 200 * i, 350, 0);
                    return;
                }
            }
        }
    }
}
