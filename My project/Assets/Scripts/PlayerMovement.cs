using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Variables")] 
    public float playerSpeed = 5f;
    private Vector2 movement;

    [Header("Components")]
    private Rigidbody2D rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        GetMovementInput();
    }

    void FixedUpdate()
    {
        MovePlayer();
    }

    private void GetMovementInput()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
    }

    private void MovePlayer()
    {
        rb.velocity = new Vector2(movement.normalized.x * playerSpeed, rb.velocity.y);
    }
}
