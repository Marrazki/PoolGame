using UnityEngine;

public class BolaBlanca : MonoBehaviour
{
    public InventarioBools inventarioBools;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        {
            if (collision.gameObject.CompareTag("BOLA"))
            Debug.Log("COLISI�N");
            inventarioBools.UpdateRebotes();
        }
    }
}
