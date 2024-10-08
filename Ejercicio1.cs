using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1 : MonoBehaviour
{
    public int waiting_frames = 120; // Parámetro para el número de frames a esperar
    private Vector3 color_vector;    // Vector de color
    private int frame_counter = 0;   // Contador de frames

    // Start is called before the first frame update
    void Start()
    {
        int number1 = Random.Range(0, 257); // 257 is exclusive
        int number2 = Random.Range(0, 257);
        int number3 = Random.Range(0, 257);
        color_vector = new Vector3(number1,number2,number3);
        UpdateColor();
    }

    // Update is called once per frame
    void Update()
    {
        frame_counter++;

        if (frame_counter >= waiting_frames)
        {
            color_vector[Random.Range(0, 3)] = Random.Range(0, 257);
            UpdateColor(); // Llama a la función para aplicar el nuevo color
            frame_counter = 0; // Reinicia el contador
        }
    }

    private void UpdateColor()
    {
        // Asigna el color al objeto (en este caso se utiliza el material del objeto)
        // Asegúrate de que el objeto tiene un Renderer y un material asignado
        Renderer renderer = GetComponent<Renderer>();
        if (renderer != null)
        {
            renderer.material.color = new Color(color_vector.x / 256f, color_vector.y / 256f, color_vector.z / 256f);
        }
        else
        {
            Debug.LogWarning("No Renderer found on this GameObject!");
        }
    }
}
