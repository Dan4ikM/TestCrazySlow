using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] private Projectile projectilePrefab;
    [SerializeField] private Transform projectileStartTransform;

    [SerializeField] private float fireRate;
    [SerializeField] private float startVelocity;

    private float timer = 1f;

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            timer = fireRate;
            Fire();
        }
    }

    void Fire()
    {
        Projectile new_projectile = Instantiate(projectilePrefab, projectileStartTransform.transform.position, projectileStartTransform.rotation);
        Vector2 startForward2d = new Vector2(projectileStartTransform.right.x, projectileStartTransform.right.y);
        new_projectile.rigidbody_2d.velocity = new Vector2(startForward2d.x, startForward2d.y) * startVelocity;
    }
}
