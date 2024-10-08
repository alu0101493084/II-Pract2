using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio6 : MonoBehaviour
{
    // Vectores de desplazamiento configurados en el marcador
    private GameObject cubo;
    private GameObject cilindro;
    private GameObject esfera;
    public Vector3 desplazamientoCubo;
    public Vector3 desplazamientoCilindro;
    public Vector3 desplazamientoEsfera;
    private Vector3 posicionCubo;
    private Vector3 posicionCilindro;
    private Vector3 posicionEsfera;
    void Start()
    {       
            cubo = GameObject.FindWithTag("Cubo2");
            cilindro = GameObject.FindWithTag("Cilindro2");
            esfera = GameObject.FindWithTag("Esfera2");
            // Obtener los vectores de desplazamiento desde la posición local del marcador
            posicionCubo = cubo.transform.position;
            posicionCilindro = cilindro.transform.position;
            posicionEsfera = esfera.transform.position;
    }

    void Update()
    {
        // Verificar si el usuario ha presionado la barra espaciadora
        if (Input.GetKeyDown(KeyCode.Space))
        {
            cubo.transform.position = posicionCubo + desplazamientoCubo;
            cilindro.transform.position = posicionCilindro + desplazamientoCilindro;
            esfera.transform.position = posicionEsfera + desplazamientoEsfera;
        }
    }
}

