using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikesDamage : MonoBehaviour
{
    private PlayerMovement player;
    private bool hasEntered;
// Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();        
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.gameObject.tag == "Player" && !hasEntered)
        {            
            hasEntered = true;
            player.Damage(1);
        }
    }
}
