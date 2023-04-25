using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class 重置按钮 : MonoBehaviour
{
    public Button resteButton;  // 引用按钮组件


    public GameObject ball;
    public GameObject board1;
    public GameObject board2;
    public GameObject board3;
    public GameObject EndUI;
    public 死亡机制 OtherScript;
    public 计时器 timer;

    private void Start()
    {
        resteButton.onClick.AddListener(reset);  // 添加响应事件
    }

    private void reset()
    {
        board1.SetActive(true);
        board2.SetActive(false);
        board3.SetActive(false);
        ball.SetActive(true);
        ball.transform.position = new Vector3(-7, 1, -7);
        ball.GetComponent<Rigidbody>().velocity = Vector3.zero;
        ball.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        OtherScript.Level = 1;
        timer.ResetTimer();
        EndUI.SetActive(false);

    }
}
