using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float rotationSpeed = 10f;

    void Update()
    {
        float rotationX = Input.GetAxis("Mouse X") * rotationSpeed;
        float rotationY = Input.GetAxis("Mouse Y") * rotationSpeed;
        transform.Rotate(Vector3.up, -rotationX, Space.World);
        transform.Rotate(Vector3.right, rotationY, Space.World);
    }
}
