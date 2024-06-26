using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float velocity = 5f;
    
    public Rigidbody2D rb;
    public Animator animator;

    private Vector2 movement;


    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }
    private void FixedUpdate()
    {
        if (DialogoManager.GetInstance().dialogueIsPlaying)
        {
            return;
        }

        rb.MovePosition(rb.position + movement * velocity * Time.fixedDeltaTime);
    }
}
