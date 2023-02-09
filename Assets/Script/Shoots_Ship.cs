using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoots_Ship : MonoBehaviour
{
    /*
    OBJETIVOS
    - NAVE
        -  Cuando se pulsa ESPACIO se crea una bala
           - Prefab -> Modelo 3D 
             Proyectil
    */

    [Header("Prefabs")]
    [SerializeField]
    GameObject bullet;
    [SerializeField]
    GameObject ship;

    void Update()
    {
        //If the user clicks
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            //Creates a "bullet"
            Instantiate(bullet, transform.localPosition, transform.localRotation);
        }
    }
}
