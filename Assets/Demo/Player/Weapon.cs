using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform FirePoint;
    public GameObject SnowballPrefab;

    // Update is called once per frame
    void Update()
    {
        //calls the shoot function when you press the fire button
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }

        void Shoot()
        {
            //Function that makes the shooty bang bang happen.
            Instantiate(SnowballPrefab, FirePoint.position, FirePoint.rotation);
        }


    }
}
