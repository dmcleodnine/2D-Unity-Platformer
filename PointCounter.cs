using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointCounter : MonoBehaviour
{
    public Text pointScoreCounter;
    public Text livesCounter;

    GameManager manny;

    void Start()
    {
        manny = (GameManager)FindObjectOfType(typeof(GameManager));
    }

    // Update is called once per frame
    void Update()
    {
        pointScoreCounter.text = "Score: " + manny.highScore;
    }
}
