using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7 : MonoBehaviour
{
    // Referencias a los objetos en la escena
    private GameObject cubo;
    private GameObject cilindro;

    // Colores de reemplazo
    public Color colorCilindro;   // Color que deseas para el cilindro
    public Color colorCubo;      // Color que deseas para el cubo

    void Start()
    {
        // Buscar los objetos en la escena
        cubo = GameObject.Find("Cubo2");
        cilindro = GameObject.Find("Cilindro2");
    }
    void Update()
    {
        // Detectar cuando se presiona la tecla 'C'
        if (Input.GetKeyDown(KeyCode.C))
        {
            Renderer rendererCilindro = cilindro.GetComponent<Renderer>();
            rendererCilindro.material.color = colorCilindro;
        }

        // Detectar cuando se presiona la flecha arriba
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Renderer rendererCubo = cubo.GetComponent<Renderer>();
            rendererCubo.material.color = colorCubo;
        }
    }
}