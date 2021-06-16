using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float Delay = 0.5f, Timer = 0.0f, SpawnMax, SpawnMin,Height;
    public GameObject enemy;

    void Start()
    {
        Timer = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Delay >= Timer)
        {
            Timer += Time.deltaTime;

        }
        else if(Delay <= Timer)
        {
            Timer = 0;
            var position = new Vector3(Random.Range(SpawnMax, SpawnMin), Height, 0); 
            Instantiate(enemy, position, Quaternion.Euler(new Vector3(0,0,180)));
        }
    }
}
