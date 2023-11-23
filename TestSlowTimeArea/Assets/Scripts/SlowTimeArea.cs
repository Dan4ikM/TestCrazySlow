using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowTimeArea : MonoBehaviour
{
    [SerializeField] private float scale = 0.1f;
    private void OnTriggerEnter2D(Collider2D collider_2d)
    {
        if (collider_2d.TryGetComponent<Rigidbody2D>(out Rigidbody2D rigidbody_2d))
        {
            rigidbody_2d.velocity *= scale;
            rigidbody_2d.gravityScale *= scale * scale;
        }
    }

    private void OnTriggerExit2D(Collider2D collider_2d)
    {
        if (collider_2d.TryGetComponent<Rigidbody2D>(out Rigidbody2D rigidbody_2d))
        {
            rigidbody_2d.velocity /= scale;
            rigidbody_2d.gravityScale /= scale * scale;
        }
    }
}
