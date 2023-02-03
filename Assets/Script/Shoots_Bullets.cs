using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoots_Bullets : MonoBehaviour
{
    [Header("Customizable")]
    [SerializeField]
    float speed = 10f;

    void Update()
    {
        transform.position += (transform.forward * speed * Time.deltaTime);
    }
}
