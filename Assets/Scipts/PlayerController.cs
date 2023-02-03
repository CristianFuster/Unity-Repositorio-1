using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //speed always float
    public float speed = 10.0f;
    public float jumpForce = 10.0f;
    private Rigidbody2D rigidbody = new Rigidbody2D();
    public GameObject groundRayObject;
    
    //Input and vector contruction
    private Vector2 dir;
    private float h = 0f;
    private float v = 0f;

    //is doing things
    private bool JumpPressed = false;
    private bool facingRight=true;
    private bool ShootPressed = false;
    private bool isGrounded= true;
    private bool isCrounched = true;

    // Start is called before the first frame update
    void Start()
    {
        //Initialize at start component
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //1. Move
        //Here we get wether A or D, left or right has pressed
        h = Input.GetAxis("Horizontal");
        //Here we get wether W or S, up or down has pressed
        v = Input.GetAxis("Vertical");


        if (Input.GetKeyDown(KeyCode.UpArrow) && isGrounded==true) {
            JumpPressed = true;
            GetComponent<Animator>().SetBool("isJumping", true);
        }

        if (Input.GetKeyDown(KeyCode.Space)) {
            ShootPressed = true;
        }


        if (Input.GetKeyDown(KeyCode.DownArrow) && isGrounded == true)
        {
            isCrounched = true;
            
        }
        else {
            isCrounched = false;
           
        }


        //Object to hold x,y dupla
        dir = new Vector2(h, 0);

    }

    private void FixedUpdate()
    {
        //Apply to rigidbody that contains this component, diagonal speed, normalized (do not increase)
        rigidbody.velocity = dir.normalized * speed;

        if (JumpPressed == true) { 
            rigidbody.AddForce(Vector2.up*jumpForce,ForceMode2D.Impulse);
            JumpPressed = false;
        }

        if (h > 0 && !facingRight){ Flip(); }
        if (h < 0 && facingRight) { Flip(); }


        //Detección de suelo
        RaycastHit2D hitGround = Physics2D.Raycast(groundRayObject.transform.position, -Vector2.up);
        //Debug.Log("HG distante" + hitGround.distance);
        //Debug.DrawRay(groundRayObject.transform.position, -Vector2.up * hitGround.distance, Color.red);

        if (hitGround.collider != null) {
            if (hitGround.distance <= 0.2)
            {
                //Debug.Log("si g");
                isGrounded = true;
            }
            else {
                //Debug.Log("no g");
                isGrounded =false; 
            }
        }


        //2. Animation states transitions
        GetComponent<Animator>().SetBool("isRunningR", h < 0 || h > 0);
        GetComponent<Animator>().SetBool("isJumping", v > 0);
        GetComponent<Animator>().SetBool("isCrouching", v < 0);

        if (h == 0)
        {
            GetComponent<Animator>().SetBool("isShootingStill", ShootPressed);
            ShootPressed = false;
        }
        if (h < 0 || h > 0)
        {
            GetComponent<Animator>().SetBool("isShootingRunning", ShootPressed);
            ShootPressed = false;
        }

        //Debug.Log("valor V: " + v);
        //Debug.Log("valor H: " + h);



    }

    void Flip(){
        Vector3 currentScale = gameObject.transform.localScale;
        currentScale.x *= -1;
        
        gameObject.transform.localScale = currentScale;

        facingRight = !facingRight;

    }
}
