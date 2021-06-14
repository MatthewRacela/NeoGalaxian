using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    private Vector3 mousePosition;
    public float moveSpeed = 0.1f;
    public bool moveable;
    public GameObject GM;
    Pause pa;

    // Use this for initialization
    void Start()
    {
        moveable = true;

        pa = GM.GetComponent<Pause>();
    }

    // Update is called once per frame
    void Update()
    {
        if (moveable)
        {
            if (Input.GetMouseButton(1))
            {
                mousePosition = Input.mousePosition;
                mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
                gameObject.transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);

            }
        }
        
        

    }

    
}
