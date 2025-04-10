using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;

    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    private void FixedUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smootheredPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smootheredPosition;

        transform.LookAt(target);
    }
}
