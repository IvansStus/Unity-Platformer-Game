using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    private int health = 1;
    private float speed;
    private PlayerMovement player;
    public bool FindPlayer = false;
    private bool dead;
    //private bool moving;

    private EnemyVision vision;

    private Rigidbody2D rb;
    private Animator enemyAnim;


    void Awake()
    {
        this.FindPlayer = false;
    }
    // Use this for initialization
    void Start()
    {
        enemyAnim = GetComponent<Animator>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
        rb = GetComponent<Rigidbody2D>();
        vision = GameObject.FindGameObjectWithTag("GameController").GetComponent<EnemyVision>();
        speed = 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            this.dead = true;
            this.enemyAnim.SetBool("Dead", dead);
            Destroy(gameObject, 0.3f);
            //FindPlayer = false;
        }
        if (vision.vision)
        {
            move();
        }              
    }

    private void move()
    {
        this.transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    public void TakeDamage(int damage)
    {
        this.health -= damage;        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //this.moving = false;
        if (collision.collider.gameObject.tag == "Player")
        {
            player.Damage(1);
        }
    }
}
