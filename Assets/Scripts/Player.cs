using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float yMoveSpeed = 5f;
    [SerializeField] float zMoveSpeed = 5f;

    SpriteRenderer sR;

    void Start()
    {
        sR = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        PlayerMovement();
    }

    private void PlayerMovement()
    {
        float yMoveAmount = Input.GetAxis("Vertical") * yMoveSpeed * Time.deltaTime;
        float zMoveAmount = Input.GetAxis("Horizontal") * zMoveSpeed * Time.deltaTime;

        transform.Translate(0, yMoveAmount, zMoveAmount);
    }
}
