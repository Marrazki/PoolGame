using UnityEngine;

public class InventarioBools : MonoBehaviour
{
    public static InventarioBools Instance { get; private set; }
    [Header("SLOTS")]
    public bool[] slot = new bool[6];
    [Header("DIAMANTES")]
    public bool[] diamanteAgujeroNegro = new bool[6];
    public bool[] diamanteBolaLisaX10 = new bool[6];
    public bool[] diamanteBolaRayadaX10 = new bool[6];
    public bool[] diamanteRebote = new bool[6];
    public bool[] diamanteTiroRandom = new bool[6];
    public bool[] diamanteX3MULT = new bool[6];
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
