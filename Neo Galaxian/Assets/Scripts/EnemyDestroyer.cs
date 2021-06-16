using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestroyer : MonoBehaviour
{
    public float DTime = 1.0f, ttime = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
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
}
