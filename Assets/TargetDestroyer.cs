using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{

    public int health = 90;

    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health < 0)
        {
            //moricion
            Destroy(gameObject);
        }
    }

}
