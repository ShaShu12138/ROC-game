using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 玩家控制 : MonoBehaviour
{
    private Rigidbody playerRb;
    public int rotationX = 0;
    public int rotationZ = 0;
    public bool moveAble = true;
    public 死亡机制 OtherScript;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (OtherScript.dying == false)
        {
            //纵向控制
            if (Input.GetKey(KeyCode.W) && (rotationX == 0 || (rotationX > -30f && rotationX < 30f)))
            {
                rotationX++;
            }
            else if (Input.GetKey(KeyCode.S) && (rotationX == 0 || (rotationX < 30f && rotationX > -30f)))
            {
                rotationX--;
            }
            else
            {
                if (rotationX < 40 && rotationX > 0 && !Input.GetKey(KeyCode.W))
                {
                    rotationX--;
                }
                if (rotationX > -40 && rotationX < 0 && !Input.GetKey(KeyCode.S))
                {
                    rotationX++;
                }
            }

            //横向控制
            if (Input.GetKey(KeyCode.A) && (rotationZ == 0 || (rotationZ > -30f && rotationZ < 30f)))
            {
                rotationZ++;
            }
            else if (Input.GetKey(KeyCode.D) && (rotationZ == 0 || (rotationZ > -30f && rotationZ < 30f)))
            {
                rotationZ--;
            }
            else
            {
                if (rotationZ < 40 && rotationZ > 0 && !Input.GetKey(KeyCode.A))
                {
                    rotationZ--;
                }
                if (rotationZ > -40 && rotationZ < 0 && !Input.GetKey(KeyCode.D))
                {
                    rotationZ++;
                }
            }
            Vector3 rotation = new Vector3(rotationX, 0f, rotationZ); // 将旋转角度封装到一个 Vector3 中
            Quaternion newRotation = Quaternion.Euler(rotation); // 将 Vector3 转换成一个四元数
            playerRb.MoveRotation(newRotation); // 使用 MoveRotation 函数进行旋转

        }
        else
        {
            rotationZ = 0;
            rotationX = 0;
            Vector3 rotation = new Vector3(0, 0f, 0); // 将旋转角度封装到一个 Vector3 中
            Quaternion newRotation = Quaternion.Euler(rotation); // 将 Vector3 转换成一个四元数
            playerRb.angularVelocity = Vector3.zero;
            playerRb.rotation=newRotation; // 使用 MoveRotation 函数进行旋转
            OtherScript.dying = false;
        }

      
    }
}

        
