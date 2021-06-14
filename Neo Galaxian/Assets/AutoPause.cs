using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoPause : MonoBehaviour
{
    public GameObject GM;
   
    GameOver GO;

    void Start()
    {
        GM = GameObject.FindWithTag("GameManager");
        GO = GM.GetComponent<GameOver>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GO.GameOverLoss = true;
            Destroy(collision.gameObject);
        }
    }
}
