using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4 : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // Obtener la posición de la esfera
        Vector3 posicionEsfera = gameObject.transform.position;

        // Mostrar la posición en la consola
        Debug.Log("Posición de la esfera: " + posicionEsfera);
    }
}
