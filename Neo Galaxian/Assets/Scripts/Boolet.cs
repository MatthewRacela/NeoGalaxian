using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boolet : MonoBehaviour
{
    public GameObject GM;
    PointSystem PS;

    public float DTime = 1.0f, ttime = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        GM = GameObject.FindWithTag("GameManager");
        PS = GM.GetComponent<PointSystem>();
        ttime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (DTime >= ttime)
        {
            ttime += Time.deltaTime;
        }
        else if (DTime <= ttime)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            PS.points += 10;
        }
    }
}
