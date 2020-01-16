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
    public float DestroyTime = 0.1f;

    void Update()
    {
        if (fireCountdown <= 0)
        {
            Shoot();
            fireCountdown = 1.5f / fireRate;
        }

        fireCountdown -= Time.deltaTime;
    }

    void Shoot()
    {
       var bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * fireRate;

        Destroy(bullet, DestroyTime);
    }

}
