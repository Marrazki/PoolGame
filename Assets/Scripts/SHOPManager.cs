using UnityEngine;

public class SHOPManager : MonoBehaviour
{
    public GameManager gameManager;
    public InventarioBools inventarioBools;
    public GameObject inventarioBoolsGO;
    public Randomizador randomizador;
    public AudioManager audioManager;
    [Header("PRECIOS DIAMANTES")]
    public int precioDiamanteAgujeroNegro = 15;
    public int preciodiamanteBolaLisaMas10 = 7;
    public int preciodiamanteBolaRayadaMas10 = 7;
    public int precioDiamanteRebote = 10;
    public int precioDiamanteTiroRandom = 8;
    public int precioDiamanteX3MULT = 30;
    [Header("PRECIOS MEJORAS")]
    public int precioMejoraTiros = 20;
    [Header("PREFABS")]
    public GameObject prefabDiamanteAgujeroNegro;
    public GameObject prefabDiamanteBolaLisaMas10;
    public GameObject prefabDiamanteBolaRayadaMas10;
    public GameObject prefabDiamanteRebote;
    public GameObject prefabDiamanteTiroRandom;
    public GameObject prefabDiamanteX3MULT;
    public GameObject prefabDiamanteVacio;
    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("AUDIO").GetComponent<AudioManager>();
    }
    public void ComprarDiamanteAgujeroNegro()
    {
        if (gameManager.dinero >= precioDiamanteAgujeroNegro)
        {
            for (int i = 0; i < 7; i++)
            {
                if (inventarioBools.slot[i] == false)
                {
                    audioManager.PlaySFX(audioManager.dinero);
                    gameManager.dinero = gameManager.dinero - precioDiamanteAgujeroNegro;
                    inventarioBools.diamanteAgujeroNegro[i] = true;
                    inventarioBools.slot[i] = true;
                    GameObject diamanteTemp = Instantiate(prefabDiamanteAgujeroNegro.gameObject, new Vector3(0, 0, 0), new Quaternion(0f, 0f, 0f, 1f)) as GameObject;
                    diamanteTemp.transform.SetParent(inventarioBoolsGO.transform.GetChild(0).GetChild(i));
                    randomizador.imagenDiamanteAgujeroNegro.transform.localPosition = new Vector3(0, 1000, 0);
                    diamanteTemp.transform.localPosition = Vector3.zero;
                    return;
                }
            }
        }
    }
    public void ComprardiamanteBolaLisaMas10()
    {
        if (gameManager.dinero >= precioDiamanteAgujeroNegro)
        {
            for (int i = 0; i < 7; i++)
            {
                if (inventarioBools.slot[i] == false)
                {
                    audioManager.PlaySFX(audioManager.dinero);
                    gameManager.dinero = gameManager.dinero - precioDiamanteAgujeroNegro;
                    inventarioBools.diamanteBolaLisaMas10[i] = true;
                    inventarioBools.slot[i] = true;
                    GameObject diamanteTemp = Instantiate(prefabDiamanteAgujeroNegro.gameObject, new Vector3(0, 0, 0), new Quaternion(0f, 0f, 0f, 1f)) as GameObject;
                    diamanteTemp.transform.SetParent(inventarioBoolsGO.transform.GetChild(0).GetChild(i));
                    randomizador.imagenDiamanteAgujeroNegro.transform.localPosition = new Vector3(0, 1000, 0);
                    diamanteTemp.transform.localPosition = Vector3.zero;
                    return;
                }
            }
        }
    }
    public void ComprardiamanteBolaRayadaMas10()
    {
        if (gameManager.dinero >= precioDiamanteAgujeroNegro)
        {
            for (int i = 0; i < 7; i++)
            {
                if (inventarioBools.slot[i] == false)
                {
                    audioManager.PlaySFX(audioManager.dinero);
                    gameManager.dinero = gameManager.dinero - precioDiamanteAgujeroNegro;
                    inventarioBools.diamanteBolaRayadaMas10[i] = true;
                    inventarioBools.slot[i] = true;
                    GameObject diamanteTemp = Instantiate(prefabDiamanteAgujeroNegro.gameObject, new Vector3(0, 0, 0), new Quaternion(0f, 0f, 0f, 1f)) as GameObject;
                    diamanteTemp.transform.SetParent(inventarioBoolsGO.transform.GetChild(0).GetChild(i));
                    randomizador.imagenDiamanteAgujeroNegro.transform.localPosition = new Vector3(0, 1000, 0);
                    diamanteTemp.transform.localPosition = Vector3.zero;
                    return;
                }
            }
        }
    }
    public void ComprarDiamanteRebote()
    {
        if (gameManager.dinero >= precioDiamanteAgujeroNegro)
        {
            for (int i = 0; i < 7; i++)
            {
                if (inventarioBools.slot[i] == false)
                {
                    audioManager.PlaySFX(audioManager.dinero);
                    gameManager.dinero = gameManager.dinero - precioDiamanteAgujeroNegro;
                    inventarioBools.diamanteRebote[i] = true;
                    inventarioBools.slot[i] = true;
                    GameObject diamanteTemp = Instantiate(prefabDiamanteAgujeroNegro.gameObject, new Vector3(0, 0, 0), new Quaternion(0f, 0f, 0f, 1f)) as GameObject;
                    diamanteTemp.transform.SetParent(inventarioBoolsGO.transform.GetChild(0).GetChild(i));
                    randomizador.imagenDiamanteAgujeroNegro.transform.localPosition = new Vector3(0, 1000, 0);
                    diamanteTemp.transform.localPosition = Vector3.zero;
                    return;
                }
            }
        }
    }
    public void ComprarDiamanteTiroRandom()
    {
        if (gameManager.dinero >= precioDiamanteAgujeroNegro)
        {
            for (int i = 0; i < 7; i++)
            {
                if (inventarioBools.slot[i] == false)
                {
                    audioManager.PlaySFX(audioManager.dinero);
                    gameManager.dinero = gameManager.dinero - precioDiamanteAgujeroNegro;
                    inventarioBools.diamanteTiroRandom[i] = true;
                    inventarioBools.slot[i] = true;
                    GameObject diamanteTemp = Instantiate(prefabDiamanteAgujeroNegro.gameObject, new Vector3(0, 0, 0), new Quaternion(0f, 0f, 0f, 1f)) as GameObject;
                    diamanteTemp.transform.SetParent(inventarioBoolsGO.transform.GetChild(0).GetChild(i));
                    randomizador.imagenDiamanteAgujeroNegro.transform.localPosition = new Vector3(0, 1000, 0);
                    diamanteTemp.transform.localPosition = Vector3.zero;
                    return;
                }
            }
        }
    }
    public void ComprarDiamanteX3MULT()
    {
        if (gameManager.dinero >= precioDiamanteAgujeroNegro)
        {
            for (int i = 0; i < 7; i++)
            {
                if (inventarioBools.slot[i] == false)
                {
                    audioManager.PlaySFX(audioManager.dinero);
                    gameManager.dinero = gameManager.dinero - precioDiamanteAgujeroNegro;
                    inventarioBools.diamanteX3MULT[i] = true;
                    inventarioBools.slot[i] = true;
                    GameObject diamanteTemp = Instantiate(prefabDiamanteAgujeroNegro.gameObject, new Vector3(0, 0, 0), new Quaternion(0f, 0f, 0f, 1f)) as GameObject;
                    diamanteTemp.transform.SetParent(inventarioBoolsGO.transform.GetChild(0).GetChild(i));
                    randomizador.imagenDiamanteAgujeroNegro.transform.localPosition = new Vector3(0, 1000, 0);
                    diamanteTemp.transform.localPosition = Vector3.zero;
                    return;
                }
            }
        }
    }
    public void ComprarMejoraTiros()
    {
        if (gameManager.dinero >= precioMejoraTiros)
        {
            {
                audioManager.PlaySFX(audioManager.dinero);
                gameManager.dinero = gameManager.dinero - precioMejoraTiros;
                gameManager.tirosMax++;
                randomizador.imagenMejoraTiros.transform.localPosition = new Vector3(0, 1000, 0);
            }
        }
    }
}
