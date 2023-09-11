using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bullet;
    Animator anim;

    private void Start()
    {
        anim = GetComponent < Animator>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
           shoot();
        }
    }
    void shoot()
    {
        Instantiate(bullet, firePoint.position, firePoint.rotation);
    }
}
