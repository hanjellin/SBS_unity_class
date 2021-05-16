using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : charscript
{
    public override void Move()
    {
        Vector3 moveDir = Vector3.zero;

        animator.SetTrigger("dowalkside");
        animator.SetTrigger("dowalkback");
        animator.SetTrigger("dowalkfront");

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            moveDir += Vector3.left;
            animator.SetTrigger("dowalkside");
            spriteRenderer.flipX = true;
        }
        
        if (Input.GetKey(KeyCode.RightArrow))
        {
            moveDir += Vector3.right;
            animator.SetTrigger("dowalkside");
            spriteRenderer.flipX = false;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            moveDir += Vector3.up;
            animator.SetTrigger("dowalkback");
            spriteRenderer.flipX = false;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            moveDir += Vector3.down;

            animator.SetTrigger("dowalkfront");
            spriteRenderer.flipX = false;
        }
        if(moveDir != Vector3.zero)
        {
            transform.position += moveDir * moveSpeed * Time.deltaTime;
            animator.SetBool("iswalking",true);
        }
        else
        {
            animator.SetBool("iswalking", false);
        }

        
    }
}
