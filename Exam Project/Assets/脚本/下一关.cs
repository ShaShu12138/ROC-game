using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 下一关 : MonoBehaviour
{
    public GameObject ball;
    public 死亡机制 OtherScript;


    private void OnTriggerEnter(Collider other)
    {
        // 检查碰撞对象是否为 ball
        if (other.gameObject == ball)
        {
            OtherScript.NextLevel();
        }
    }


}
