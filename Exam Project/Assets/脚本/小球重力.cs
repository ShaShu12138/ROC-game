using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 小球重力 : MonoBehaviour
{

	Rigidbody body;

    void Awake()
    {
        body = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
	{
		body.AddForce(new Vector3(0, -500, 0));
	}
}
