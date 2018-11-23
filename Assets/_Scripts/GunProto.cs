using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RangerKarl
{

    public class GunProto : MonoBehaviour
    {
        [Tooltip("The GameObject representing a bullet.")]
        public GameObject bulletPrefab;
        public int projoForce = 6;
        private bool isShooting;

        [Tooltip("The transform point determining the spawn point of the bullet")]
        public Transform bulletSpawn;
        // Start is called before the first frame update
        void Start()
        {
            isShooting = false;
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            if (Input.GetButton("Fire1") && !isShooting)
            {
                Fire();
                
            }
            if (Input.GetButtonUp("Fire1") )
            {
                isShooting = false;
            }
        }

        private void Fire()
        {
            // Create the Bullet from the Bullet Prefab
            var bullet = (GameObject)Instantiate(
                bulletPrefab,
                bulletSpawn.position,
                bulletSpawn.rotation );

            // Add velocity to the bullet
            bullet.GetComponent<Rigidbody>().AddForce(bullet.transform.forward * projoForce);

            isShooting = true;
            // Destroy the bullet after 2 seconds
            Destroy(bullet, 2.0f);
        }
    }
}
