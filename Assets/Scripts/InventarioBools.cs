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
        if (this.gameObject.transform.parent == slot1)
        {
            slot[1] = false;
            diamanteBolaLisaMas10[1] = false;
        }
        if (this.gameObject.transform.parent == slot2)
        {
            slot[2] = false;
            diamanteBolaLisaMas10[2] = false;
        }
        if (this.gameObject.transform.parent == slot3)
        {
            slot[3] = false;
            diamanteBolaLisaMas10[3] = false;
        }
        if (this.gameObject.transform.parent == slot4)
        {
            slot[4] = false;
            diamanteBolaLisaMas10[4] = false;
        }
        if (this.gameObject.transform.parent == slot5)
        {
            slot[5] = false;
            diamanteBolaLisaMas10[5] = false;
        }
        if (this.gameObject.transform.parent == slot6)
        {
            slot[6] = false;
            diamanteBolaLisaMas10[6] = false;
        }
    }
    public void VenderDiamanteBolaRayadaMas10()
    {
        if (this.gameObject.transform.parent == slot1)
        {
            slot[1] = false;
            diamanteBolaRayadaMas10[1] = false;
        }
        if (this.gameObject.transform.parent == slot2)
        {
            slot[2] = false;
            diamanteBolaRayadaMas10[2] = false;
        }
        if (this.gameObject.transform.parent == slot3)
        {
            slot[3] = false;
            diamanteBolaRayadaMas10[3] = false;
        }
        if (this.gameObject.transform.parent == slot4)
        {
            slot[4] = false;
            diamanteBolaRayadaMas10[4] = false;
        }
        if (this.gameObject.transform.parent == slot5)
        {
            slot[5] = false;
            diamanteBolaRayadaMas10[5] = false;
        }
        if (this.gameObject.transform.parent == slot6)
        {
            slot[6] = false;
            diamanteBolaRayadaMas10[6] = false;
        }
    }
    public void VenderDiamanteRebote()
    {
        if (this.gameObject.transform.parent == slot1)
        {
            slot[1] = false;
            diamanteRebote[1] = false;
        }
        if (this.gameObject.transform.parent == slot2)
        {
            slot[2] = false;
            diamanteTiroRandom[2] = false;
        }
        if (this.gameObject.transform.parent == slot3)
        {
            slot[3] = false;
            diamanteTiroRandom[3] = false;
        }
        if (this.gameObject.transform.parent == slot4)
        {
            slot[4] = false;
            diamanteTiroRandom[4] = false;
        }
        if (this.gameObject.transform.parent == slot5)
        {
            slot[5] = false;
            diamanteTiroRandom[5] = false;
        }
        if (this.gameObject.transform.parent == slot6)
        {
            slot[6] = false;
            diamanteTiroRandom[6] = false;
        }
    }
    public void VenderDiamanteTiroRandom()
    {
        if (this.gameObject.transform.parent == slot1)
        {
            slot[1] = false;
            diamanteTiroRandom[1] = false;
        }
        if (this.gameObject.transform.parent == slot2)
        {
            slot[2] = false;
            diamanteTiroRandom[2] = false;
        }
        if (this.gameObject.transform.parent == slot3)
        {
            slot[3] = false;
            diamanteTiroRandom[3] = false;
        }
        if (this.gameObject.transform.parent == slot4)
        {
            slot[4] = false;
            diamanteTiroRandom[4] = false;
        }
        if (this.gameObject.transform.parent == slot5)
        {
            slot[5] = false;
            diamanteTiroRandom[5] = false;
        }
        if (this.gameObject.transform.parent == slot6)
        {
            slot[6] = false;
            diamanteTiroRandom[6] = false;
        }
    }
    public void VenderDiamanteX3MULT()
    {
        if (this.gameObject.transform.parent == slot1)
        {
            slot[1] = false;
            diamanteX3MULT[1] = false;
        }
        if (this.gameObject.transform.parent == slot2)
        {
            slot[2] = false;
            diamanteX3MULT[2] = false;
        }
        if (this.gameObject.transform.parent == slot3)
        {
            slot[3] = false;
            diamanteX3MULT[3] = false;
        }
        if (this.gameObject.transform.parent == slot4)
        {
            slot[4] = false;
            diamanteX3MULT[4] = false;
        }
        if (this.gameObject.transform.parent == slot5)
        {
            slot[5] = false;
            diamanteX3MULT[5] = false;
        }
        if (this.gameObject.transform.parent == slot6)
        {
            slot[6] = false;
            diamanteX3MULT[6] = false;
        }
    }
}
