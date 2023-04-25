using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class 计时器 : MonoBehaviour
{
    public Text timerText;
    private float startTime;
    private bool isRunning = false;
    public string timerString;

    void Start()
    {
        startTime = Time.time;
        isRunning = true;
    }

    void Update()
    {
        if (isRunning)
        {
            float elapsedTime = Time.time - startTime;
            TimeSpan timeSpan = TimeSpan.FromSeconds(elapsedTime);
            timerString = string.Format("{0:D2}:{1:D2}:{2:D3}", timeSpan.Minutes, timeSpan.Seconds, timeSpan.Milliseconds);
            timerText.text = "Timer: " + timerString;
        }
    }

    public void StopTimer()
    {
        isRunning = false;
    }
    public void ResetTimer()
    {
        startTime = Time.time;
        isRunning = true;
    }
}
