using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wormMove : MonoBehaviour
{
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void FixedUpdate()
    {
        rb.velocity = Vector2.left;
    }
}
