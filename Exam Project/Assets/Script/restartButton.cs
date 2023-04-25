using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class restartButton : MonoBehaviour
{
    public Button resteButton;  


    public GameObject ball;
    public GameObject board1;
    public GameObject board2;
    public GameObject board3;
    public GameObject EndUI;
    public death OtherScript;
    public timer timer;

    private void Start()
    {
        resteButton.onClick.AddListener(reset);  // AddListener(onclick)
    }

    private void reset()
    {
        //reset the boards
        board1.SetActive(true);
        board2.SetActive(false);
        board3.SetActive(false);

        //reset the ball
        ball.SetActive(true);
        ball.transform.position = new Vector3(-7, 1, -7);
        ball.GetComponent<Rigidbody>().velocity = Vector3.zero;
        ball.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;

        //reset other script and timer
        OtherScript.Level = 1;
        timer.ResetTimer();
        EndUI.SetActive(false);

    }
}
