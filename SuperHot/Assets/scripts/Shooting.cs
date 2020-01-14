using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    GameObject target;
    public float fireRate = 1f;
    private float fireCountdown = 0f;
    private float speed = 10f;
    public GameObject bulletPrefab;
    public Transform firePoint;



    void Update()
    {

        if (fireCountdown <= 0)
        {
            Shoot();
            fireCountdown = 9f / fireRate;
        }

        fireCountdown -= Time.deltaTime;

    }

    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }

}
