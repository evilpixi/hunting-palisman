using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAim : MonoBehaviour
{
    //delay
    public float nextFire = 0.0f;
    public float fireRate = 0.5f;


    public Transform playerAim;
    public GameObject bulletPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Shoot();
        }
    }

    //function that shoots
    void Shoot()
    {
        Instantiate(bulletPrefab, playerAim.position, playerAim.rotation);
    }
}
