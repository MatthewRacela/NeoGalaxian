using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    public GameObject GM;
    GameOver GO;
    void Start()
    {
        GM = GameObject.FindWithTag("GameManager");
        GO = GM.GetComponent<GameOver>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            GO.GameOverLoss = true;
            Destroy(gameObject);
        }
    }
}
