using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour
{
    private Rigidbody playerRb;
    public float rotationX = 0;
    public float rotationZ = 0;
    public bool moveAble = true;
    public death OtherScript;
    public Vector2 deltaAxis;

   
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }


    private void Update()
    {
        deltaAxis = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }
    void FixedUpdate()
    {
        if (OtherScript.dying == false)
        {
            Vector3 rotation = new Vector3(deltaAxis.y*30, 0f, deltaAxis.x*-30); // set a new V3
            Quaternion newRotation = Quaternion.RotateTowards(playerRb.rotation, Quaternion.Euler(rotation),1.5f); // Vector3 to Quaternion
            playerRb.MoveRotation(newRotation); // Rotate with MoveRotation


        }
        else
        {
            rotationZ = 0;
            rotationX = 0;
            Vector3 rotation = new Vector3(0, 0f, 0); // set a new V3
            Quaternion newRotation = Quaternion.Euler(rotation); //  Vector3 to Quaternion
            playerRb.angularVelocity = Vector3.zero;
            playerRb.rotation=newRotation; // Rotate with MoveRotation
            OtherScript.dying = false;//set death bool to false
        }

      
    }
}

        
