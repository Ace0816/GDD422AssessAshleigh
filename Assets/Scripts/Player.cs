using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //ChatGPT
    [SerializeField] float moveSpeed = 5f; //movement speed, set with serialize field so it can be changed in the inspector without needing to open the code
    
    private Rigidbody2D rb2D; //reference to the 2d rigidbody component 
    private Vector2 moveInput; 

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>(); //calling the 2d rigidbody component
    }

    void Update()
    {
        //gets the horizontal and vertical inputs that allow for player movement with WASD or arrow keys
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        //applies movement to the player object based on player input, then multiplied by the speed
        rb2D.velocity = new Vector2(moveInput.x * moveSpeed, moveInput.y * moveSpeed);
    }
}

    
