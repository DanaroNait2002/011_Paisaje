using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov_Ship : MonoBehaviour
{
    [Header("Speed")]
    //Movement speed
    [SerializeField]
    float speed = 5f;
    //Rotation X speed
    [SerializeField]
    float speedRotationVertical = 20f;
    //Rotation Y speed
    [SerializeField]
    float speedRotationHorizontal = 20f;

    [SerializeField]
    Vector3 initialRotation;

    void Update()
    {
        //When "W" or "S" are being press the ship goes "Down" or "Up" respectively
        float rotationX = Input.GetAxis("Vertical") * speedRotationVertical * Time.deltaTime;
        //When "A" or "D" are being press the ship goes "Left" or "Right" respectively
        float rotationY = Input.GetAxis("Horizontal") * speedRotationHorizontal * Time.deltaTime;
        //When "A" or "D" are being press the ship inclines "Left" or "Right" respectively
        float rotationZ = - Input.GetAxis("Horizontal") * speedRotationHorizontal * Time.deltaTime;

        if (Input.GetAxis("Vertical") == 0 || Input.GetAxis("Horizontal") == 0)
        {
            Debug.Log("No esta pulsando W o S");
            //Quiero que la nave vuelva a la rotación inicial cuando no se este pulsando nada
            //transform.rotation = Quaternion.Euler(initialRotation);
        }

        transform.Rotate(rotationX, rotationY, rotationZ, Space.Self);

        transform.position += (transform.forward * speed * Time.deltaTime);
    }
}
