using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyVision : MonoBehaviour
{
    public bool vision;
    private EnemyBehavior enemy;
    void Start()
    {
        enemy = GameObject.FindGameObjectWithTag("Enemy").GetComponent<EnemyBehavior>();
        this.vision = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.tag == "Player")//or tag
        {            
            Physics2D.IgnoreCollision(collision.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());
            this.vision = true;
            //enemy.FindPlayer = true;
        }
    }
}
