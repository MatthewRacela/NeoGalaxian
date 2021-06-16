using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointSystem : MonoBehaviour
{
    public Text text1, text2;
    public int points;
    // Start is called before the first frame update
    void Start()
    {
        points = 0;
        text1.text = "Points:" + points;
        text2.text = "Points:" + points;
    }

    // Update is called once per frame
    void Update()
    {
        text1.text = "Points:" + points;
        text2.text = "Points:" + points;
    }
}
