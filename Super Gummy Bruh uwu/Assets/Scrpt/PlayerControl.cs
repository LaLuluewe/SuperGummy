using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed;
    Rigidbody2D rb;

    bool facingRight = true;

    bool isGrounded;

    bool IsTouchingFront;

    bool wallSliding;
    public float wallSlidingSpeed;
    
    bool wallJumping;

    public float XWallForce;
    public float YWallForce;
    public float wallJumpTme;


    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;
    public Transform frontCheck;

    public int health;

    

    Animator anim;
    SpriteRenderer sprite;
    public float jumpforce;
    private void Start(){
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();

    }

    private void Update(){
        float input = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(input * speed, rb.velocity.y);
        if (input > 0 && facingRight == false){
            Flip();

        }else if (input < 0 && facingRight == true ){
            Flip();

        }

        if(input != 0){
            anim.SetBool("IsRunning", true);
        }else{
            anim.SetBool("IsRunning", false);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) && isGrounded == true) {
            rb.velocity = Vector2.up * jumpforce;
        }
        if(isGrounded == true){
            anim.SetBool("IsJumping", false);

        }else{
            anim.SetBool("IsJumping", true);
        }

  
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround); 
       
        IsTouchingFront = Physics2D.OverlapCircle(frontCheck.position, checkRadius, whatIsGround);

        if (IsTouchingFront == true && isGrounded == false && input != 0){
            wallSliding = true;
        }else{
            wallSliding = false;
        }

        if(wallSliding){
            rb.velocity = new Vector2 (rb.velocity.x, Mathf.Clamp(rb.velocity.y, -wallSlidingSpeed, float.MaxValue));

        }

        if(Input.GetKeyDown(KeyCode.UpArrow) && wallSliding == true){
            wallJumping = true;
            Invoke("SetWallJumpingToFalse", wallJumpTme);
        }

        if(wallJumping == true){
            rb.velocity = new Vector2(XWallForce * -input, YWallForce);

        }

   
    }

    void Flip(){
        //sprite.flipX = !sprite.flipX;
        transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
        facingRight = !facingRight;
    }
    void SetWallJumpingToFalse(){
        wallJumping = false;
    } 

    public void TakeDamage(int damage){
        health -= damage;
        print(health);
        if(health <=0){
            Destroy(gameObject);
        }
    }

}

   