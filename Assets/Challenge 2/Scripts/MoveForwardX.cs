using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForwardX : MonoBehaviour
{
    public float speed = 30.0f;

    // Update is called once per frame
    void Update()
    {
        // Si el perro avanza hacia la izquierda en el eje global X:
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        // Nota: Asegúrate de que el Prefab esté rotado mirando hacia la izquierda en la escena, 
        // o cambia Vector3.forward por Vector3.left según cómo esté construido tu juego.
    }
}