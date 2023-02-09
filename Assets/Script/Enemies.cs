using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    /*
    OBJETIVOS 
    
    Crear un sistema de caminos para naves enemigas 
    - Requiere el uso de un array de GameObjects vac�os. (GameObject[] ruta)    
    - Acceder a cada punto del array y dirigir la nave hacia el siguiente 
        (ruta[siguientePunto])                                                  
    - Usar transform.LookAt(ruta[siguientePunto].transform) para que la nave
        mire hacia ese punto                                                    
    - Tenemos que modificar la posici�n del objeto (transform.position)         

    - ENEMIGOS
        -   Detectar colisi�n y destruirse al detectarla
    */

    [Header("Markers")]
    [SerializeField]
    GameObject[] route;
    [SerializeField]
    int currentMarker = 0;

    [Header("Customizable")]
    [SerializeField]
    float enemiesSpeed = 5f;

    void OnEnable()
    {
        //As soon as the script is enabled the GameObject look at the first Marker
        transform.LookAt(route[currentMarker].transform);
    }

    void Update()
    {
        //The GameObject look at the next Marker
        transform.LookAt(route[currentMarker].transform);

        //The GameObject is always moving forward, and as it is looking to the next Marker, it moves in that direction
        transform.position += transform.forward * enemiesSpeed * Time.deltaTime;
    }

    //When the GameObject collides with something
    private void OnTriggerEnter(Collider other)
    {
        //It compares the tag of that something
        //If it is a "Marker"
        if (other.CompareTag("Marker"))
        {
            //The next Marker is updated
            currentMarker++;

            //In case the number exceed the maximun of Markers
            if (currentMarker >= route.Length)
            {
                //It becomes 0 again to start over
                currentMarker = 0;
            }
        }

        //It compares the tag of that something
        //If it is a "Bullet"
        if (other.CompareTag("Bullet"))
        {
            //Initiates the cycle again
            transform.position = route[0].transform.position;
        }
    }

}
