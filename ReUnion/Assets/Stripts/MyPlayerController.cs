using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPlayerController : PhysicsObject
{
    public float maxSpeed = 7;
    public float jumpTakeOffSpeed = 7;
	public Joystick mov;
    public bool jump;

    private SpriteRenderer spriteRenderer;
    private Animator animator;
    
    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    protected override void ComputeVelocity()
    {
        Vector2 move = Vector2.zero;

        move.x = mov.Horizontal;

        if (mov.Vertical>0 && grounded)
        {
            velocity.y = jumpTakeOffSpeed;

            if (velocity.y > 0.0)
            {
                velocity.y = velocity.y * 1.5f;
            }
        }

        bool flipSprite = (spriteRenderer.flipX ? (move.x > 0.01f) : (move.x < 0.01f));
        if (flipSprite)
        {
            spriteRenderer.flipX = !spriteRenderer.flipX;

        }

        animator.SetBool("grounded", grounded);
        animator.SetBool("Jump", jump);
        animator.SetFloat("velocityX", Mathf.Abs(velocity.x) / maxSpeed);
        animator.SetFloat("velocityY", Mathf.Abs(velocity.y) / maxSpeed);


        targetVelocity = move * maxSpeed;
    }
}