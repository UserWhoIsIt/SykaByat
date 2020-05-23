using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.CodeDom;
using System.Diagnostics;

public class PlayerController : MonoBehaviour
{
    public float jumpForce;
    public float speed;
    public Vector2 groundPos;
    public float checkRadius;
    public float jumpTime;
    public Rigidbody2D rb;
    public bool isGrounded;
    private float jumpTimeCounter;
    public bool isJumping;
    public bool isRunning;

    public bool isAttacking;
    public LayerMask whatIsGround;

    private Animator anim;
    public AudioManager audioManager;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        audioManager = GetComponent<AudioManager>();
    }

    private void Update()
    {
        Attack();
        Jump();
        Running();
      /*  if (isJumping == true)
        {
            audioManager.Play("jump");
        }
        if(isAttacking == true)
        {
            audioManager.Play("attack1");
            audioManager.Play("attack2");
        }
        if(isRunning == true)
        {
            audioManager.Play("running");
        }  */
    }
    public void Running()
    {
        float moveInput = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        if (moveInput == 0)
        {
            anim.SetBool("isRunning", false);
        }
        else
        {
            anim.SetBool("isRunning", true);
            
        }

        if (moveInput < 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
        else if (moveInput > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        
    }
    public void Attack()
    {
        if (Input.GetKey(KeyCode.F))
        {
            anim.SetBool("isAttacking", true);
            audioManager.Play("attack1");
            audioManager.Play("attack2");
        }
        else
        {
            anim.SetBool("isAttacking", false);
        }
    }
   public void Jump()
    {
        isGrounded = Physics2D.OverlapCircle(groundPos, checkRadius, whatIsGround);

        if (isGrounded == true && Input.GetKeyDown(KeyCode.W))
        {
            anim.SetTrigger("ns");

            isJumping = true;
            jumpTimeCounter = jumpTime;
            rb.velocity = Vector2.up * jumpForce;

            if (isGrounded == true)
            {

                anim.SetBool("isJumping", false);

            }
            else
            {
                anim.SetBool("isJumping", true);
                audioManager.Play("jump");

            }



        }
        if (Input.GetKey(KeyCode.W) && isJumping == true)
        {
            if (jumpTimeCounter > 0)
            {
                rb.velocity = Vector2.up * jumpForce;
                jumpTimeCounter -= Time.deltaTime;
                anim.SetBool("isJumping", true);
                audioManager.Play("jump");
            }
            else
            {
                anim.SetBool("isJumping", false);
            }


        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            anim.SetBool("isJumping", false);
        }

        if (isGrounded == false && Input.GetKeyDown(KeyCode.W))
        {
            isJumping = true;

            isJumping = true;
            jumpTimeCounter = jumpTime;
            rb.velocity = Vector2.up * jumpForce;
        }









    }
}
 
     
