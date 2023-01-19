using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov_Camera : MonoBehaviour
{
    [SerializeField]
    float speed = 2f;

    void Update()
    {
        transform.position += (transform.forward * Time.deltaTime * speed);
    }
}
