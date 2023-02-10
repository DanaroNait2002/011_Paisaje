using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp_collider : MonoBehaviour
{
    void OnTriggerEnter(Collider player)
    {
        //It compares the tag of that something
        //If it is a "Power-Up"
        if (player.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
