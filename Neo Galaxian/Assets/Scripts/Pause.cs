using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    public bool playable;
    public bool paused;
    public bool overide;
    public bool TheButton;
    public bool NotStart;
    public GameObject Player;
    FollowMouse FM;
    PlayerMovement PM;
    public Canvas StartMenu, Pausemenu;
    public Text AltText, AltText1, AltText2, AltText3;
    // Start is called before the first frame update
    void Start()
    {
        paused = true;
        NotStart = false;
        AltText.enabled = false;
        AltText1.enabled = false;
        AltText2.enabled = true;
        AltText3.enabled = true;
        StartMenu.enabled = true;
        Pausemenu.enabled = false;
        playable = true;
        
        FM = Player.GetComponent<FollowMouse>();
        PM = Player.GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
       
        if (!overide)
        {
            FM.enabled = true;
            PM.enabled = false;
            if (Input.GetButton("Fire2") && playable)
            {
                paused = false;
                StartMenu.enabled = false;
                Pausemenu.enabled = false;

            }
            else if (Input.GetButtonUp("Fire2"))
            {
                paused = true;
                Pausemenu.enabled = true;
            }
        }
        

        

        if (overide)
        {
            Overidden();
            
        }
        
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
        if (!playable)
        {
            Time.timeScale = 0;
            paused = true;
            Pausemenu.enabled = false;
        }
    }

    void Overidden()
    {
        AltText.enabled = true;
        AltText1.enabled = true;
        AltText2.enabled = false;
        AltText3.enabled = false;
        FM.enabled = false;
        PM.enabled = true;
        if (Input.GetKeyDown(KeyCode.Q) && NotStart)
        {
            if (!TheButton)
            {
                TheButton = true;
            }
            else
            {
                TheButton = false;
            }
        }

        if (TheButton)
        {
            paused = true;
            Pausemenu.enabled = true;
        }
        else if (!TheButton)
        {
            paused = false;
            Pausemenu.enabled = false;

        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            StartMenu.enabled = false;
            paused = false;
            NotStart = true;
        }

    }


}
