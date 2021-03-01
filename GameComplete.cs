using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameComplete : MonoBehaviour
{
    private PlayerMovement player;    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("ENDScreen");            
        }
    }
}
