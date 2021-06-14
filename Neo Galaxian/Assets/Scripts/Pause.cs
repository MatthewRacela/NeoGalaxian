using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    public bool playable;
    public bool paused;
    public GameObject Player;
    FollowMouse FM;
    public Canvas StartMenu, Pausemenu;
    // Start is called before the first frame update
    void Start()
    {
        StartMenu.enabled = true;
        Pausemenu.enabled = false;
        playable = true;
        paused = true;
        FM = Player.GetComponent<FollowMouse>();
    }

    // Update is called once per frame
    void Update()
    {
        if (paused)
        {
            Time.timeScale = 0;
            FM.moveable = false;

        }
        else
        {
            Time.timeScale = 1;
            FM.moveable = true;
        }

        if (Input.GetButton("Fire2") && playable)
        {
            paused = false;
            StartMenu.enabled = false;
            
        }
        else if (Input.GetButtonUp("Fire2"))
        {
            paused = true;
            
        }

        

        if (!playable)
        {
            Time.timeScale = 0;
            paused = true;
        }
    }

    
}
