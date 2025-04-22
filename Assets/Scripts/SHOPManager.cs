using UnityEngine;

public class SHOPManager : MonoBehaviour
{
    public GameManager gameManager;
    public InventarioBools inventarioBools;
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
                    diamanteTemp.transform.parent = inventarioBools.transform;
                    randomizador.imagenDiamanteAgujeroNegro.transform.localPosition = new Vector3(0, 1000, 0);
                    diamanteTemp.transform.localPosition = new Vector3(-500 + 200 * i, 350, 0);
                    return;
                }
            }

        }
    }
    public void ComprardiamanteBolaLisaMas10()
    {
        if (gameManager.dinero >= preciodiamanteBolaLisaMas10)
        {
            for (int i = 0; i < 7; i++)
            {
                if (inventarioBools.slot[i] == false)
                {
                    audioManager.PlaySFX(audioManager.dinero);
                    gameManager.dinero = gameManager.dinero - preciodiamanteBolaLisaMas10;
                    inventarioBools.diamanteBolaLisaMas10[i] = true;
                    inventarioBools.slot[i] = true;
                    GameObject diamanteTemp = Instantiate(prefabDiamanteBolaLisaMas10.gameObject, new Vector3(0, 0, 0), new Quaternion(0f, 0f, 0f, 1f)) as GameObject;
                    diamanteTemp.transform.parent = inventarioBools.transform;
                    randomizador.imagenDiamanteBolaLisaMas10.transform.localPosition = new Vector3(0, 1000, 0);
                    diamanteTemp.transform.localPosition = new Vector3(-500 + 200 * i, 350, 0);
                    return;
                }
            }
        }
    }
    public void ComprardiamanteBolaRayadaMas10()
    {
        if (gameManager.dinero >= preciodiamanteBolaRayadaMas10)
        {
            for (int i = 0; i < 7; i++)
            {
                if (inventarioBools.slot[i] == false)
                {
                    audioManager.PlaySFX(audioManager.dinero);
                    gameManager.dinero = gameManager.dinero - preciodiamanteBolaRayadaMas10;
                    inventarioBools.diamanteBolaRayadaMas10[i] = true;
                    inventarioBools.slot[i] = true;
                    GameObject diamanteTemp = Instantiate(prefabDiamanteBolaRayadaMas10.gameObject, new Vector3(0, 0, 0), new Quaternion(0f, 0f, 0f, 1f)) as GameObject;
                    diamanteTemp.transform.parent = inventarioBools.transform;
                    randomizador.imagenDiamanteBolaLisaMas10.transform.localPosition = new Vector3(0, 1000, 0);
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
                    audioManager.PlaySFX(audioManager.dinero);
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
                    audioManager.PlaySFX(audioManager.dinero);
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
                    audioManager.PlaySFX(audioManager.dinero);
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
    public void ComprarMejoraTiros()
    {
        if (gameManager.dinero >= precioMejoraTiros)
        {
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
    public void EliminarDiamante()
    {
        for (int i = 0; i < 7; i++)
        {
            if (inventarioBools.slot[i] == false)
            {
                GameObject diamanteVacioTemp = Instantiate(prefabDiamanteVacio.gameObject, new Vector3(0, 0, 0), new Quaternion(0f, 0f, 0f, 1f)) as GameObject;
                diamanteVacioTemp.transform.parent = inventarioBools.transform;
                diamanteVacioTemp.transform.localPosition = new Vector3(-500 + 200 * i, 350, 0);
                return;
            }
        }
    }
}
