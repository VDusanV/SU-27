using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun2 : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public GameObject homing;
   
    public bool isActive = true;
    void Update()
    {
        if (Input.GetButton("Fire2"))
        {
            Shoot();
        }
       /* if (Input.GetButton("Fire3"))
        {
            ShootHoming();
        }*/
    }

  /*  private void ShootHoming()
    {
        if(isActive)
            Instantiate(homing, firePoint.position, firePoint.rotation);
        isActive = false;

    }*/

    void Shoot()
    {
        
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

    }
}
