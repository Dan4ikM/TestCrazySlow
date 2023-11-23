using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowTimeArea : MonoBehaviour
{
    [SerializeField] private float timeScale = 0.1f;
    
    [SerializeField] private bool useTimeScale;
    [SerializeField] private float globalTimeScale = 10f;
    
    private void Awake()
    {
        if (useTimeScale)
            Time.timeScale = globalTimeScale;
    }

    private void OnTriggerEnter2D(Collider2D collider_2d)
    {
        if (collider_2d.TryGetComponent<Rigidbody2D>(out Rigidbody2D rigidbody_2d))
        {
            rigidbody_2d.velocity *= timeScale;
            rigidbody_2d.gravityScale *= timeScale * timeScale;
        }
    }

    private void OnTriggerExit2D(Collider2D collider_2d)
    {
        if (collider_2d.TryGetComponent<Rigidbody2D>(out Rigidbody2D rigidbody_2d))
        {
            rigidbody_2d.velocity /= timeScale;
            rigidbody_2d.gravityScale /= timeScale * timeScale;
        }
    }
}
