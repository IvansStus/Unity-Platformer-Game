using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackTrigger : MonoBehaviour
{
    public int dmg = 1;
    private EnemyBehavior enemy;
    private EnemyBehavior1 enemy1;
    private EnemyBehavior2 enemy2;
    private EnemyBehavior3 enemy3;
    private EnemyBehavior4 enemy4;
    private EnemyBehavior5 enemy5;
    private EnemyBehavior6 enemy6;
    private EnemyBehavior7 enemy7;
    private EnemyBehavior8 enemy8;
    private EnemyBehavior9 enemy9;
    private EnemyBehavior10 enemy10;
    private EnemyBehavior11 enemy11;
    private EnemyBehavior12 enemy12;
    private EnemyBehavior13 enemy13;
    private EnemyBehavior14 enemy14;
    private EnemyBehavior15 enemy15;
    public AudioSource attack;
    void Start()
    {
        enemy = GameObject.FindGameObjectWithTag("Enemy").GetComponent<EnemyBehavior>();
        enemy1 = GameObject.FindGameObjectWithTag("Enemy1").GetComponent<EnemyBehavior1>();
        enemy2 = GameObject.FindGameObjectWithTag("Enemy2").GetComponent<EnemyBehavior2>();
        enemy3 = GameObject.FindGameObjectWithTag("Enemy3").GetComponent<EnemyBehavior3>();
        enemy4 = GameObject.FindGameObjectWithTag("Enemy4").GetComponent<EnemyBehavior4>();
        enemy5 = GameObject.FindGameObjectWithTag("Enemy5").GetComponent<EnemyBehavior5>();
        enemy6 = GameObject.FindGameObjectWithTag("Enemy6").GetComponent<EnemyBehavior6>();
        enemy7 = GameObject.FindGameObjectWithTag("Enemy7").GetComponent<EnemyBehavior7>();
        enemy8 = GameObject.FindGameObjectWithTag("Enemy8").GetComponent<EnemyBehavior8>();
        enemy9 = GameObject.FindGameObjectWithTag("Enemy9").GetComponent<EnemyBehavior9>();
        enemy10 = GameObject.FindGameObjectWithTag("Enemy10").GetComponent<EnemyBehavior10>();
        enemy11 = GameObject.FindGameObjectWithTag("Enemy11").GetComponent<EnemyBehavior11>();
        enemy12 = GameObject.FindGameObjectWithTag("Enemy12").GetComponent<EnemyBehavior12>();
        enemy13 = GameObject.FindGameObjectWithTag("Enemy13").GetComponent<EnemyBehavior13>();
        enemy14 = GameObject.FindGameObjectWithTag("Enemy14").GetComponent<EnemyBehavior14>();
        enemy15 = GameObject.FindGameObjectWithTag("Enemy15").GetComponent<EnemyBehavior15>();
        attack = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.collider.gameObject.tag == "Enemy")
        {
            attack.Play();
            enemy.TakeDamage(1);
        }
        if (collision.collider.gameObject.tag == "Enemy1")
        {
            attack.Play();
            enemy1.TakeDamage(1);
        }
        if (collision.collider.gameObject.tag == "Enemy2")
        {
            attack.Play();
            enemy2.TakeDamage(1);
        }
        if (collision.collider.gameObject.tag == "Enemy3")
        {
            attack.Play();
            enemy3.TakeDamage(1);
        }
        if (collision.collider.gameObject.tag == "Enemy4")
        {
            attack.Play();
            enemy4.TakeDamage(1);
        }
        if (collision.collider.gameObject.tag == "Enemy5")
        {
            attack.Play();
            enemy5.TakeDamage(1);
        }
        if (collision.collider.gameObject.tag == "Enemy6")
        {
            attack.Play();
            enemy6.TakeDamage(1);
        }
        if (collision.collider.gameObject.tag == "Enemy7")
        {
            attack.Play();
            enemy7.TakeDamage(1);
        }
        if (collision.collider.gameObject.tag == "Enemy8")
        {
            attack.Play();
            enemy8.TakeDamage(1);
        }
        if (collision.collider.gameObject.tag == "Enemy9")
        {
            attack.Play();
            enemy9.TakeDamage(1);
        }
        if (collision.collider.gameObject.tag == "Enemy10")
        {
            attack.Play();
            enemy10.TakeDamage(1);
        }
        if (collision.collider.gameObject.tag == "Enemy11")
        {
            attack.Play();
            enemy11.TakeDamage(1);
        }
        if (collision.collider.gameObject.tag == "Enemy12")
        {
            attack.Play();
            enemy12.TakeDamage(1);
        }
        if (collision.collider.gameObject.tag == "Enemy13")
        {
            attack.Play();
            enemy13.TakeDamage(1);
        }
        if (collision.collider.gameObject.tag == "Enemy14")
        {
            attack.Play();
            enemy14.TakeDamage(1);
        }
        if (collision.collider.gameObject.tag == "Enemy15")
        {
            attack.Play();
            enemy15.TakeDamage(1);
        }


    }

}
