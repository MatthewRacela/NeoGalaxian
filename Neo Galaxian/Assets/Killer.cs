using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killer : MonoBehaviour
{
    // Start is called before the first frame update

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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            GO.GameOverLoss = true;
            Destroy(collision.gameObject);
        }
    }
}
