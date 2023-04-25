using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class endGame : MonoBehaviour
{
    public GameObject ball;
    public GameObject EndUI;
    public Text EndTime;
    public Text HighScore;

    public timer Timer;

    private void Start()
    {
        EndUI.SetActive(false);
    }
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        // Check if the collider is a ball
        if (other.gameObject == ball)
        {
            //stop timer and disappear the ball
            Timer.StopTimer();
            ball.SetActive(false);

            //show highscore
            EndUI.SetActive(true);
            EndTime.text = Timer.timerString;

            //show it as mm:ss:fff
            TimeSpan t1 = TimeSpan.ParseExact(Timer.timerString, "mm\\:ss\\:fff", null);
            TimeSpan t2 = TimeSpan.ParseExact(HighScore.text, "mm\\:ss\\:fff", null);

            //if new score,than show with green color
            if (t1 <= t2)
            {
                HighScore.text = Timer.timerString;
                EndTime.color = new Color32(92, 168, 70, 255);
            }
            else if (t1 > t2)
            {
                EndTime.color = new Color32(255, 255, 255, 255);
            }
        }
    }
}
