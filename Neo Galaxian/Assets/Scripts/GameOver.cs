using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public bool GameOverLoss;

    
    public GameObject GM;
    Pause pa;

    public Canvas LossScreen;
    void Start()
    {
        GameOverLoss = false;
       
        pa = GM.GetComponent<Pause>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameOverLoss)
        {
            LossScreen.enabled = true;
            pa.playable = false;
            Time.timeScale = 0;

            
        }
        else
        {
            LossScreen.enabled = false;
        }
    }
}
