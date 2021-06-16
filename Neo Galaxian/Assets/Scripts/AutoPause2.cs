using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoPause2 : MonoBehaviour
{
    public GameObject Player;
    public GameObject Spawn;
    public GameObject GM;
    Pause PA;
    // Start is called before the first frame update
    void Start()
    {
        GM = GameObject.FindWithTag("GameManager");
        PA = GM.GetComponent<Pause>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Boundary")
        {
            //PA.overide = true;
            //PA.paused = true;
            //PA.Pausemenu.enabled = true;
            Player.transform.position = Spawn.transform.position;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        
    }
}
