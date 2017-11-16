using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_health : MonoBehaviour {
    private float health = 100;
    private float damage = 10;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Zombie")
        {
            Debug.Log(health);
            health -= damage;
        }
    }
}
