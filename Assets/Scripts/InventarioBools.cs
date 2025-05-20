using UnityEngine;

public class InventarioBools : MonoBehaviour
{
    public static InventarioBools Instance { get; private set; }
    public GameManager gameManager;
    public AudioManager audioManager;
    [Header("SLOTS")]
    public bool[] slot = new bool[6];
    public GameObject slot0;
    public GameObject slot1;
    public GameObject slot2;
    public GameObject slot3;
    public GameObject slot4;
    public GameObject slot5;
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
    
    
    
    
    
    
   
}
