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

    EXAMEN
    - Si el jugador deja sostenida la tecla de ataque se dispare en modo semiautomático un projectil cada 0.75s
    - El valor se debe poder modificar desde el inspector de unity

    - Al coger el Power-up la nave pordrá disparar más seguido (cambiar a 0.325s)
    - El efecto dura 20s
    */

    [Header("Prefabs")]
    [SerializeField]
    GameObject bullet;
    [SerializeField]
    GameObject ship;

    [Header("Customizable")]
    [SerializeField]
    float cooldownConstant;
    [SerializeField]
    float cooldown = 0.75f;
    [SerializeField]
    float cooldownPowerUp = 0.325f;
    [SerializeField]
    float timer;
    [SerializeField]
    float timerPowerUp = 20f;
    [SerializeField]
    bool powerUp = false;
    [SerializeField]
    bool shoot = false;

    void Start()
    {
        //As soon as the script starts the timer is set equal than cooldown
        timer = cooldown;
        cooldownConstant = cooldown;
    }

    void Update()
    {
        //If the user clicks and timer is higher or has the same value as cooldown
        if (Input.GetKey(KeyCode.Space) && timer >= cooldown)
        {
            //The player has shoot
            shoot = true;
            //Creates a "bullet"
            Instantiate(bullet, transform.localPosition, transform.localRotation);
        }

        //If timer is lower than 0
        if (timer <= 0)
        {
            //Timer becomes equal than the cooldown
            timer = cooldown;
            //Then the bool is changed to false
            shoot = false;
        }

        if (timerPowerUp <= 0)
        {
            powerUp = false;

            cooldown = cooldownConstant;
        }

        if (powerUp == true)
        {
            timerPowerUp -= Time.deltaTime;
        }

        //If shoot is true (the player has shoot)
        if (shoot == true)
        {
            //Timer lower 1 per second
            timer -= Time.deltaTime;
        }
    }
    void OnTriggerEnter(Collider power_up)
    {
        //It compares the tag of that something
        //If it is a "Power-Up"
        if (power_up.CompareTag("Power-Up"))
        {
            timerPowerUp = 20f;
            powerUp = true;

            cooldown = cooldownPowerUp;
        }
    }
    /*
    Tiempo entre disparos y tiempo que ha pasado
    Una vez dispara ese tiempo se hace 0 lo hace dentro del if y el va sumando, yo restando

    El Power up resta también, entonces al restar en dos partes se tarda la mitad con un coeficiente inicial y uno a la mitad, que se multiplica al coldown
    */
}
