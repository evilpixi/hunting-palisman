using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShoot : MonoBehaviour
{
    //damage
    public int damage = 35; 


    public float flyingSpeed = 20f;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        //speed of the bullet
        rb.velocity = transform.right * flyingSpeed;
    }

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        TargetEnemy enemy = GetComponent<TargetEnemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }

        Destroy(gameObject);
    }

}
