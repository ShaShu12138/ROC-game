using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballScript : MonoBehaviour
{

	Rigidbody body;

    void Awake()
    {
        body = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
	{
        //Adding a downward force makes the ball stick to the board, simulating greater gravity
        body.AddForce(new Vector3(0, -500, 0));
	}
}
