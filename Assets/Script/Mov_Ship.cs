using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov_Ship : MonoBehaviour
{
    [Header("Speed")]
    //Movement speed
    [SerializeField]
    float speed = 0.0f;
    //Rotation X speed
    [SerializeField]
    float speedRotationVertical = 10f;
    //Rotation Y
    [SerializeField]
    float speedRotationHorizontal = 10f;


    void Update()
    {
        float rotationX = Input.GetAxis("Vertical") * speedRotationVertical * Time.deltaTime;
        float rotationY = - Input.GetAxis("Horizontal") * speedRotationHorizontal * Time.deltaTime;
        float rotationZ = Input.GetAxis("Horizontal") * speedRotationHorizontal * Time.deltaTime;

        transform.Rotate(rotationX, rotationY, rotationZ, Space.Self);

        transform.position += (transform.forward * Time.deltaTime * speed);
    }
}
