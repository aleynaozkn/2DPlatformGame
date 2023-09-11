using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField] private GameObject carrotBullet;
    [SerializeField] private Transform carrotBulletPos;
    [SerializeField] private SpriteRenderer carrotBulletSpr;
    private float timer;
    private GameObject enemy;
    private float distance;
    void Start()
    {
        enemy = GameObject.FindGameObjectWithTag("Enemy");
    }

    void Update()
    {
        distance = Vector2.Distance(transform.position, enemy.transform.position);
        if (distance < 8)
        {
            timer += Time.deltaTime;

            if (timer > 2)
            {
                carrotBulletSpr.enabled = false;
                Invoke("EnableTrue",1.9f);
                timer = 0;
                Shoot();
            }
        }

    }

    private void Shoot()
    {
        Instantiate(carrotBullet, carrotBulletPos.position, Quaternion.identity);
    }
    private void EnableTrue()
    {
        carrotBulletSpr.enabled = true;
    }
}
