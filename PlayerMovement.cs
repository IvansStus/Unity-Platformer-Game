using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    public float jumpForce;
    private Vector2 moveDirection;    
    public Transform groundCheck;
    public LayerMask groundObjects;
    public float checkRadius;
    private float movementDir;
    public int curHealth;
    public int maxHealth = 5;

    private Rigidbody2D rb;
    private Animator anim;
    private bool dead = false;
    private bool isJumping = false;
    private bool isGrounded = false;

    public AudioSource[] collisionSounds;

    public AudioSource collision1;
    public AudioSource collision2;
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        moveSpeed = 5;
        jumpForce = 7;
        checkRadius = 0.05f;       
        maxHealth = 5;
        curHealth = maxHealth;
        collisionSounds = GetComponents<AudioSource>();
        collision1 = collisionSounds[0];
        collision2 = collisionSounds[1];        
    }

    // Update is called once per frame
    void Update()
    {
        processInputs();
        processAnimations();        
        CheckIfGrounded();        

        if (curHealth > maxHealth)
        {
            curHealth = maxHealth;
        }
        if (curHealth <= 0)
        {
            curHealth = 0;
            Die();
        }
    }

    void FixedUpdate()
    {        
        move();
    }

    private void processInputs()
    {
        float moveDirectionH = UnityEngine.Input.GetAxis("Horizontal");
        float moveDirectionV = UnityEngine.Input.GetAxis("Vertical");
        moveDirection = new Vector2(moveDirectionH, moveDirectionV).normalized; 
        movementDir = UnityEngine.Input.GetAxis("Horizontal");
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            collision1.Play();
            isJumping = true;            
        }
    }

    private void processAnimations()
    {
        anim.SetFloat("Horizontal", moveDirection.x);
        anim.SetFloat("Vertical", moveDirection.y);
        anim.SetFloat("MoveMag", moveDirection.magnitude);
    }

    private void move()
    {
        rb.velocity = new Vector2(movementDir * moveSpeed, rb.velocity.y);
        if (isJumping)
        {
            rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);            
        }        
        isJumping = false;
    }

    void CheckIfGrounded()
    {
        Collider2D collider = Physics2D.OverlapCircle(groundCheck.position, checkRadius, groundObjects);
        if (collider != null)
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }
    }

    void Die()
    {
        dead = true;
        anim.SetBool("Death", dead);
        SceneManager.LoadScene("DeathScene");
    }

    public void Damage(int dmg)
    {        
        collision2.Play();
        curHealth -= dmg;        
    }

}
