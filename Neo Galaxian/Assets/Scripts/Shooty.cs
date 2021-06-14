using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooty : MonoBehaviour
{
    public Transform ShootPoint;
    public GameObject Pew;

    public float ShotDelay = 0.5f, CurrentTime = 0.0f;
    public bool CanShoot;

    // Start is called before the first frame update
    void Start()
    {
        CurrentTime = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(ShotDelay > CurrentTime)
        {
            CurrentTime += Time.deltaTime;
            CanShoot = false;
        }
        else if(ShotDelay <= CurrentTime)
        {
            CanShoot = true;
            CurrentTime = 0;
        }

        if (CanShoot)
        {
            Instantiate(Pew, ShootPoint.position, Quaternion.identity);
        }
    }
}
