using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoots_Bullets : MonoBehaviour
{
    /*
    OBJETIVOS
    - PROYECTIL
        -   Avanzar forward
        -   Limite de tiempo
    */

    [Header("Customizable")]
    [SerializeField]
    float speed = 10f;
    [SerializeField]
    float timer;

    //When the script is activated the timer is set on 10
    void OnEnable()
    {
        //timer being the lifespawn of the bullet
        timer = 10f;
    }

    void Update()
    {
        //The bullet is always moving forward
        transform.position += (transform.forward * speed * Time.deltaTime);

        //The timer loose a second per second
        timer -= Time.deltaTime;

        //If timer is minor that 0
        if (timer <= 0)
        {
            //Destroy the bullet
            Destroy(gameObject);
        }
    }
    /*
    Hizo un vector 3 direccionFuerza
    La bala tiene un collider y un rigid
    gameobject.GetComponent<Rigidbody>.AddForce(direccionFuerza, ForceMode.Impulse);
    */
}
