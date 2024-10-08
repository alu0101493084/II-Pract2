using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio8 : MonoBehaviour
{
    private GameObject cubo;
    public Color colorLejana; // Color para la esfera más lejana
    public float alturaIncremento = 2.0f; 
    void Start()
    {
        // Buscar el cubo por nombre
        cubo = GameObject.Find("Cubo");
    }
    void Update()
    {
        // Detectar si el jugador pulsa la tecla espacio
        if (Input.GetKeyDown(KeyCode.Space))
        {
            CambiarEsferaMasLejana();
        }

        // Aumentar la altura de la esfera más cercana
        AumentarAlturaEsferaMasCercana();
    }

    // Método para aumentar la altura de la esfera más cercana al cubo
    void AumentarAlturaEsferaMasCercana()
    {
        GameObject esferaMasCercana = null;
        GameObject[] esferas = GameObject.FindGameObjectsWithTag("Tipo 2");
        float menorDistancia = Mathf.Infinity;
        foreach (GameObject esfera in esferas)
        {
            float distancia = Vector3.Distance(cubo.transform.position, esfera.transform.position);
            if (distancia < menorDistancia)
            {
                menorDistancia = distancia;
                esferaMasCercana = esfera;
            }
        }
        // Aumentar la altura (componente Y) de la esfera más cercana
        Vector3 nuevaPosicion = esferaMasCercana.transform.position;
        nuevaPosicion.y += alturaIncremento;
        esferaMasCercana.transform.position = nuevaPosicion;
    }

    // Método para cambiar el color de la esfera más lejana del cubo
    void CambiarEsferaMasLejana()
    {
    GameObject esferaMasLejana = null;
    GameObject[] esferasTipo2 = GameObject.FindGameObjectsWithTag("Tipo 2");
    GameObject[] esferasTipo1 = GameObject.FindGameObjectsWithTag("Tipo 1");
    // Combina ambas listas de esferas
    List<GameObject> esferas = new List<GameObject>(esferasTipo2);
    esferas.AddRange(esferasTipo1);
    float mayorDistancia = 0f;
    foreach (GameObject esfera in esferas)
    {
        float distancia = Vector3.Distance(cubo.transform.position, esfera.transform.position);
        if (distancia > mayorDistancia)
        {
            mayorDistancia = distancia;
            esferaMasLejana = esfera;
        }
    }
    Renderer rendererEsfera = esferaMasLejana.GetComponent<Renderer>();
    rendererEsfera.material.color = colorLejana;
    }
}