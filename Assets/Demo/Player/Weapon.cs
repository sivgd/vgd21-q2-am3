using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform FirePoint;
    public GameObject SnowballPrefab;
    public float cooldownTime = 2;
    private float nextfireTime = 0;

    // Update is called once per frame
    void Update()
    {

        if (Time.time > nextfireTime)
        {
            //calls the shoot function when you press the fire button
            if (Input.GetButtonDown("Fire1"))
            {
                Shoot();
                nextfireTime = Time.time + cooldownTime;

            }
        }
        void Shoot()
        {
            //Function that makes the shooty bang bang happen.
            Instantiate(SnowballPrefab, FirePoint.position, FirePoint.rotation);
        }


    }
}
