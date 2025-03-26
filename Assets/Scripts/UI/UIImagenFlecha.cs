using UnityEngine;

public class UIImagenFlecha : MonoBehaviour
{
    public GameManager gameManager;

    void Update()
    {
        if (gameManager.fuerza == 0.5f)
        {
            transform.position = new Vector3(110, 50, 0);
        }
        if (gameManager.fuerza == 1f)
        {
            transform.position = new Vector3(110, 130, 0);
        }
        if (gameManager.fuerza == 1.5f)
        {
            transform.position = new Vector3(110, 210, 0);
        }
        if (gameManager.fuerza == 2f)
        {
            transform.position = new Vector3(110, 290, 0);
        }
        if (gameManager.fuerza == 2.5f)
        {
            transform.position = new Vector3(110, 370, 0);
        }
        if (gameManager.fuerza == 3f)
        {
            transform.position = new Vector3(110, 450, 0);
        }
    }
}
