using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5 : MonoBehaviour
{
    private GameObject cubo;
    private GameObject cilindro;
    void Start()
    {
        // Buscar los objetos por su nombre en la escena
        cubo = GameObject.FindWithTag("Cubo2");
        cilindro = GameObject.FindWithTag("Cilindro2");

        // Comprobar si se encontraron los objetos
        if (cubo == null)
        {
            Debug.LogError("No se pudo encontrar el objeto 'Cubo2' en la escena.");
        }
        if (cilindro == null)
        {
            Debug.LogError("No se pudo encontrar el objeto 'Cilindro2' en la escena.");
        }
    }

    void Update()
    {
        if (cubo != null && cilindro != null)
        {
            Vector3 posicionEsfera = transform.position;
            Vector3 posicionCubo = cubo.transform.position;
            Vector3 posicionCilindro = cilindro.transform.position;

            // Calcular las distancias entre la esfera y los otros objetos
            float distanciaAlCubo = Vector3.Distance(posicionEsfera, posicionCubo);
            float distanciaAlCilindro = Vector3.Distance(posicionEsfera, posicionCilindro);

            // Mostrar las distancias en la consola
            Debug.Log("Distancia de la esfera al cubo: " + distanciaAlCubo);
            Debug.Log("Distancia de la esfera al cilindro: " + distanciaAlCilindro);
        }
    }
}
