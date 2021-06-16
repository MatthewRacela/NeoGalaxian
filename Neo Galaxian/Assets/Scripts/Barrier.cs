using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrier : MonoBehaviour
{
    public int barrierblocks, StartingBlocks;
    void Start()
    {
        barrierblocks = StartingBlocks;
    }

    // Update is called once per frame
    void Update()
    {
        if(barrierblocks <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "EnemyBoo")
        {
            Destroy(collision.gameObject);
            barrierblocks--;
            
        }

        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            barrierblocks--;
            
        }

    }
    
}
