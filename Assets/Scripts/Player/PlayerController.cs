using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed;

    private Rigidbody2D rb2d;
    private Vector2 moveInput;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    
    private void Update()
    {
        rb2d.linearVelocity = moveInput * moveSpeed;
    }

    public void Move(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }

    
}
