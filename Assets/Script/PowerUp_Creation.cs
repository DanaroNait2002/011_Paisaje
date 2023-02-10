using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp_Creation : MonoBehaviour
{
    /*
    EXAMEN
    - Aparece en una posición aleatoria cada 20 a 40s (se debe poder modificar desde el inspector)
    - Al coger el jugador el Power-up este desaparece y volverá a aparecer con un valor constante de 40s (se puede modificar desde el inspector) + el rango de tiempo comprendido visto en el punto anterior
    */

    [Header("Positions")]
    [SerializeField]
    GameObject[] positions;
    [SerializeField]
    int currentPosition = 0;

    [Header("Timers")]
    [SerializeField]
    float timeMin = 20f;
    [SerializeField]
    float timeMax = 40f;
    [SerializeField]
    float timeConstant;
    [SerializeField]
    float timer;
    [SerializeField]
    bool firstPowerUp;

    [Header("prefabs")]
    [SerializeField]
    GameObject powerUp;

    void Start()
    {
        timer = Random.Range(timeMin, timeMax);
        timeConstant = timer;

        currentPosition = Random.Range(0, positions.Length);
    }

    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            Instantiate(powerUp, positions[currentPosition].transform.localPosition, Quaternion.identity);
            timer = Random.Range(timeMin, timeMax) + timeConstant;

            currentPosition = Random.Range(0, positions.Length);
        }
    }
}
