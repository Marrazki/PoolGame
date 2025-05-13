using UnityEngine;

public class InventarioBools : MonoBehaviour
{
    public static InventarioBools Instance { get; private set; }
    public GameManager gameManager;
    public AudioManager audioManager;
    [Header("SLOTS")]
    public bool[] slot = new bool[6];
    public GameObject slot1;
    public GameObject slot2;
    public GameObject slot3;
    public GameObject slot4;
    public GameObject slot5;
    public GameObject slot6;
    [Header("DIAMANTES")]
    public bool[] diamanteAgujeroNegro = new bool[6];
    public bool[] diamanteBolaLisaMas10 = new bool[6];
    public bool[] diamanteBolaRayadaMas10 = new bool[6];
    public bool[] diamanteRebote = new bool[6];
    public bool[] diamanteTiroRandom = new bool[6];
    public bool[] diamanteX3MULT = new bool[6];
    [Header("Variables")]
    public int randomTiro;
    public bool agujeroNegro;
    private void Awake()
    {
        //Singleton
        if (InventarioBools.Instance == null)
        {
            InventarioBools.Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {

    }

    // Update is called once per frame
    public void UpdateDiamantes()
    {
        for (int i = 0; i < 6; i++)
        {
            if (diamanteX3MULT[i] == true)
            {
                gameManager.multiplicador = gameManager.multiplicador * 3;
            }
        }
    }
    public void UpdateRebotes()
    {
        for (int i = 0; i < 6; i++)
        {
            if (diamanteRebote[i] == true)
            {
                gameManager.multiplicador++;
            }
        }
    }
    public void UpdateTirosRandom()
    {
        for (int i = 0; i < 6; i++)
        {
            if (diamanteTiroRandom[i] == true)
            {
                randomTiro = Random.Range(0, 3);
                if (randomTiro == 2)
                {
                    gameManager.tiros++;
                }
            }
        }
    }
    public void UpdateBolasLisasPuntuacion()
    {
        for (int i = 0; i < 6; i++)
        {
            if (diamanteBolaLisaMas10[i] == true)
            {
                gameManager.bolaLisaNivel++;
            }
        }
    }
    public void UpdateBolasRayadasPuntuacion()
    {
        for (int i = 0; i < 6; i++)
        {
            if (diamanteBolaRayadaMas10[i] == true)
            {
                gameManager.bolaRayadaNivel++;
            }
        }
    }
    public void UpdateAgujeroNegro()
    {
        for (int i = 0; i < 6; i++)
        {
            if (diamanteAgujeroNegro[i] == true)
            {
                agujeroNegro = true;
                diamanteAgujeroNegro[i] = false;
                slot[i] = false;

            }
            if (agujeroNegro == true)
            {
                return;
            }
        }
    }
    //VENDER
    /*
    public void VenderDiamanteAgujeroNegro()
    {
        if (this.gameObject.transform.parent == slot1)
        { 
            slot[1] = false;
            diamanteAgujeroNegro[1] = false;
        }
        if (this.gameObject.transform.parent == slot2)
        {
            slot[2] = false;
            diamanteAgujeroNegro[2] = false;
        }
        if (this.gameObject.transform.parent == slot3)
        {
            slot[3] = false;
            diamanteAgujeroNegro[3] = false;
        }
        if (this.gameObject.transform.parent == slot4)
        {
            slot[4] = false;
            diamanteAgujeroNegro[4] = false;
        }
        if (this.gameObject.transform.parent == slot5)
        {
            slot[5] = false;
            diamanteAgujeroNegro[5] = false;
        }
        if (this.gameObject.transform.parent == slot6)
        {
            slot[6] = false;
            diamanteAgujeroNegro[6] = false;
        }
    }
    public void VenderDiamanteBolaLisaMas10()
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
    public void VenderDiamanteBolaRayadaMas10()
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
    public void VenderDiamanteRebote()
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
    public void VenderDiamanteTiroRandom()
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
    public void VenderDiamanteX3MULT()
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
    }*/
}
