using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class PlayerController : MonoBehaviour
{
    public float jumpForce;
    public float speed;
    public Vector2 groundPos;
    public float checkRadius;
    public float jumpTime;
    public Rigidbody2D rb;
    private bool isGrounded;
    private float jumpTimeCounter;
    private bool isJumping;
    
    private bool isAttacking;
    public LayerMask whatIsGround;

    private Animator anim;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {

        if (Input.GetKey(KeyCode.F))
            {
            isAttacking = true;
        }
        else
        {
            isAttacking = false;
        }


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
            }



        }
        if (Input.GetKey(KeyCode.W) && isJumping == true)
        {
            if (jumpTimeCounter >0)
            {
                rb.velocity = Vector2.up * jumpForce;
                jumpTimeCounter -= Time.deltaTime;
            }
            else
            {
                isJumping = false;
            }


        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            isJumping = false;
        }

        if (isGrounded == false && Input.GetKeyDown(KeyCode.W))
        {
            isJumping = true;
            
            isJumping = true;
            jumpTimeCounter = jumpTime;
            rb.velocity = Vector2.up * jumpForce;
        }

        float moveInput = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        if (moveInput ==0)
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







}
