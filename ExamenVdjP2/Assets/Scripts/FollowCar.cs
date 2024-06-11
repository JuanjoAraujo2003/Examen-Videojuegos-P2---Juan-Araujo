using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCar : MonoBehaviour
{
    public Transform carrito; 
    public float height = 10.0f; 
    public float followSpeed = 2.0f; 
    public float rotationDamping = 3.0f; 

    void LateUpdate()
    {
        if (carrito == null)
        {
            Debug.LogWarning("El objeto 'carrito' no está asignado.");
            return;
        }

        
        Vector3 desiredPosition = new Vector3(carrito.position.x, 200, carrito.position.z);

        
        transform.position = Vector3.Lerp(transform.position, desiredPosition, followSpeed * Time.deltaTime);

        
        Quaternion desiredRotation = Quaternion.Euler(90, carrito.eulerAngles.y, 0);
        transform.rotation = Quaternion.Slerp(transform.rotation, desiredRotation, rotationDamping * Time.deltaTime);
    }
}
