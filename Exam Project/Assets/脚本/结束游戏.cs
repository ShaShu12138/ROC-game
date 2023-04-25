using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class 结束游戏 : MonoBehaviour
{
    public GameObject ball;
    public GameObject EndUI;
    public Text EndTime;
    public Text HighScore;

    public 计时器 Timer;

    private void Start()
    {
        EndUI.SetActive(false);
    }
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        // 检查碰撞对象是否为 ball
        if (other.gameObject == ball)
        {
            Timer.StopTimer();
            ball.SetActive(false);

            //弹出界面并判断最高分
            EndUI.SetActive(true);
            EndTime.text = Timer.timerString;

            TimeSpan t1 = TimeSpan.ParseExact(Timer.timerString, "mm\\:ss\\:fff", null);
            TimeSpan t2 = TimeSpan.ParseExact(HighScore.text, "mm\\:ss\\:fff", null);
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
