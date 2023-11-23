using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public Rigidbody2D rigidbody_2d { get; set; } 
    
    private void Awake()
    {
        rigidbody_2d = GetComponent<Rigidbody2D>();
    }
}
