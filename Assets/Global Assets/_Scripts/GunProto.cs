using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunProto : MonoBehaviour
{
    [Tooltip("The GameObject representing a bullet.")]
    public GameObject bulletPrefab;

    [Tooltip("The transform point determining the spawn point of the bullet")]
    public Transform bulletSpawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            Fire(); 
        }
    }

    private void Fire()
    {
        // Create the Bullet from the Bullet Prefab
        var bullet = (GameObject)Instantiate(
            bulletPrefab,
            bulletSpawn.position,
            bulletSpawn.rotation);

        // Add velocity to the bullet
        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 6;

        // Destroy the bullet after 2 seconds
        Destroy(bullet, 2.0f);
    }
}
