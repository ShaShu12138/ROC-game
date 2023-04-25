using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 死亡机制 : MonoBehaviour
{
    public GameObject ball;
    public GameObject board1;
    public GameObject board2;
    public GameObject board3;
    public bool dying = false;
    public int Level = 1;

    private void Start()
    {
        board2.SetActive(false);
        board3.SetActive(false);
    }

    void FixedUpdate()
    {
        if (ball.transform.position.y < -20f)
        {
            
            dying = true;
            if (Level == 1)
            {
                ball.transform.position = new Vector3(-7, 1, -7);
            }
            if (Level == 2)
            {
                ball.transform.position = new Vector3(-7.75f, 1, 0);
            }
            if (Level == 3)
            {
                ball.transform.position = new Vector3(-7, 1, -7);
            }
            ball.GetComponent<Rigidbody>().velocity = Vector3.zero;
            ball.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        }
    }
    public void NextLevel()
    {
        
        if (Level == 2)
        {
            // 销毁关卡
            board3.SetActive(true);
            dying = true;
            board3.transform.rotation = Quaternion.Euler(0, 0, 0);
            board3.transform.position = new Vector3(0, 0, 0);
            ball.transform.position = new Vector3(-7, 1, -7);
            ball.GetComponent<Rigidbody>().velocity = Vector3.zero;
            ball.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            board2.SetActive(false);
        }
        if (Level == 1)
        {
            // 销毁关卡
            board2.SetActive(true);
            dying = true;
            board2.transform.rotation = Quaternion.Euler(0, 0, 0);
            board2.transform.position = new Vector3(0, 0, 0);
            ball.transform.position = new Vector3(-7.75f, 1, 0);
            ball.GetComponent<Rigidbody>().velocity = Vector3.zero;
            ball.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            board1.SetActive(false);
        }
        Level++;
    }
}
