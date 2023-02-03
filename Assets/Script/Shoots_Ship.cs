using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoots_Ship : MonoBehaviour
{
    /*
    DOS SCRIPTS
    - NAVE
        -  Cuando se pulsa ESPACIO se crea una bala
           - Prefab -> Modelo 3D 
             Proyectil

    - PROYECTIL
        -   Avanzar forward
        -   Limite de tiempo

    - ENEMIGOS
        -   Detectar colisi�n y destruirse al detectarla
    */

    [Header("Prefabs")]
    [SerializeField]
    GameObject bullet;
    [SerializeField]
    GameObject ship;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bullet, transform.localPosition, transform.localRotation);
        }
    }
}
