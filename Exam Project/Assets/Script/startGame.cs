using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class startGame : MonoBehaviour
{
    public Button startButton;  

    public GameObject ball;
    public GameObject board1;
    public GameObject timer;
    public GameObject startScreen;

    private void Start()
    {
        startButton.onClick.AddListener(start);  // AddListener(onclick)
    }

    private void start()
    {
        //reset the board and ball. STart the timer.
        board1.SetActive(true);
        ball.SetActive(true);
        startScreen.SetActive(false);
        timer.SetActive(true);

    }
}
