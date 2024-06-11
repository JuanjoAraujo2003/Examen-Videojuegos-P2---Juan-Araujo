using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    // Variables para la velocidad y la fuerza de giro
    public float speed = 200.0f;
    public float turnSpeed = 50.0f;

    void Update()
    {
        // Obtener la entrada del usuario para avanzar/retroceder
        float moveDirection = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        // Obtener la entrada del usuario para girar
        float turnDirection = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;

        // Mover el carro hacia adelante/atrás
        transform.Translate(Vector3.forward * moveDirection);
        // Girar el carro
        transform.Rotate(Vector3.up * turnDirection);
    }
}
