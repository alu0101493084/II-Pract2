using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3 : MonoBehaviour
{
    public Vector3 vector1;
    public Vector3 vector2;
    private int waiting_frames = 2500;
     private int frame_counter = 0;
    // Update is called once per frame
    /*La magnitud de cada uno de ellos. 
    El ángulo que forman
    La distancia entre ambos.
    Un mensaje indicando qué vector está a una altura mayor.*/

    void Update()
    {
        frame_counter++;
        if (frame_counter >= waiting_frames) {
            frame_counter = 0;
            float angle = Vector3.Angle(vector1,vector2);
            float distance = Vector3.Distance(vector1,vector2);
            string highest_vector;
            if (vector1.y >= vector2.y) {
                highest_vector = "Vector1";
            } else {
                highest_vector = "Vector2";
            }
            Debug.Log("Magnitud Vector1: " + vector1.magnitude + "\nMagnitud Vector2: " + vector2.magnitude + "\nÁngulo: " + angle + "\nDistancia: " + distance + "\n" + highest_vector + " está a una altura mayor.");
        }
    }
}
