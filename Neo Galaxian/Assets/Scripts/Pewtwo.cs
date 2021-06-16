using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pewtwo : MonoBehaviour
{
    public Rigidbody2D Pewpew;

    public float speed = -10.0f;

    // Start is called before the first frame update
    void Start()
    {
        Pewpew = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Pewpew.velocity = new Vector2(0, 1) * speed;
    }
}
