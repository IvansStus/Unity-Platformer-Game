using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private bool AttackRight = false;
    private float attackTimer = 0;
    private float attackCd = 0.3f;
    public Collider2D Attacktrigger;
    private Animator anim;

    void Awake()
    {
        anim = gameObject.GetComponent<Animator>();
        Attacktrigger.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {        
        if (Input.GetKeyDown("space") && !AttackRight)
        {
            AttackRight = true;
            attackTimer = attackCd;
            Attacktrigger.enabled = true;
        }
        if (AttackRight)
        {
            if (attackTimer > 0)
            {               
                attackTimer -= Time.deltaTime;
            }            
            else
            {                
                AttackRight = false;
                Attacktrigger.enabled = false;
            }
        }        
        anim.SetBool("AttackRight", AttackRight);
    }    
}
