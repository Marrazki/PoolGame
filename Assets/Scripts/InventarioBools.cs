using UnityEngine;

public class InventarioBools : MonoBehaviour
{
    public static InventarioBools Instance { get; private set; }
    [Header("SLOTS")]
    public bool slot1;
    public bool slot2;
    public bool slot3;
    public bool slot4;
    public bool slot5;
    public bool slot6;
    [Header("DIAMANTES")]
    public bool diamanteAgujeroNegro_1;
    public bool diamanteAgujeroNegro_2;
    public bool diamanteAgujeroNegro_3;
    public bool diamanteAgujeroNegro_4;
    public bool diamanteAgujeroNegro_5;
    public bool diamanteAgujeroNegro_6;

    public bool diamanteBolaLisaX10_1;
    public bool diamanteBolaLisaX10_2;
    public bool diamanteBolaLisaX10_3;
    public bool diamanteBolaLisaX10_4;
    public bool diamanteBolaLisaX10_5;
    public bool diamanteBolaLisaX10_6;

    public bool diamanteBolaRayadaX10_1;
    public bool diamanteBolaRayadaX10_2;
    public bool diamanteBolaRayadaX10_3;
    public bool diamanteBolaRayadaX10_4;
    public bool diamanteBolaRayadaX10_5;
    public bool diamanteBolaRayadaX10_6;

    public bool diamanteRebote_1;
    public bool diamanteRebote_2;
    public bool diamanteRebote_3;
    public bool diamanteRebote_4;
    public bool diamanteRebote_5;
    public bool diamanteRebote_6;

    public bool diamanteTiroRandom_1;
    public bool diamanteTiroRandom_2;
    public bool diamanteTiroRandom_3;
    public bool diamanteTiroRandom_4;
    public bool diamanteTiroRandom_5;
    public bool diamanteTiroRandom_6;

    public bool diamanteX3MULT_1;
    public bool diamanteX3MULT_2;
    public bool diamanteX3MULT_3;
    public bool diamanteX3MULT_4;
    public bool diamanteX3MULT_5;
    public bool diamanteX3MULT_6;
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
    void Update()
    {
        
    }
}
