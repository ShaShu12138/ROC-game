using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextLevel : MonoBehaviour
{
    public GameObject ball;
    public death OtherScript;


    private void OnTriggerEnter(Collider other)
    {
        // Check if the collider is a ball
        if (other.gameObject == ball)
        {
            OtherScript.NextLevel();
        }
    }


}
