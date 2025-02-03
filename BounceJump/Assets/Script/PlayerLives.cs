using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLives : MonoBehaviour
{
    static public int Lives = 3;
    public GameObject FirstLive;
    public GameObject SecondLive;
    public GameObject ThirdLive;
    public GameObject FourthLive;
    public GameObject FifthLive;
    public GameObject GameOverText;
    public GameObject GameOverButton;

    void Start()
    {
        GetComponent<PlayerMovement>();
    }
    void Update()
    {
        if (Lives == 1)
        {
            FirstLive.active = true;
            SecondLive.active = false;
            ThirdLive.active = false;
            FourthLive.active = false;
            FifthLive.active = false;
        }

        if (Lives == 2)
        {
            FirstLive.active = true;
            SecondLive.active = true;
            ThirdLive.active = false;
            FourthLive.active = false;
            FifthLive.active = false;
        }

        if (Lives == 3)
        {
            FirstLive.active = true;
            SecondLive.active = true;
            ThirdLive.active = true;
            FourthLive.active = false;
            FifthLive.active = false;
        }

        if (Lives == 4)
        {
            FirstLive.active = true;
            SecondLive.active = true;
            ThirdLive.active = true;
            FourthLive.active = true;
            FifthLive.active = false;
        }

        if (Lives == 5)
        {
            FirstLive.active = true;
            SecondLive.active = true;
            ThirdLive.active = true;
            FourthLive.active = true;
            FifthLive.active = true;
        }

        if (Lives > 5)
        {
            Lives = 5;
        }

        if (Lives <= 0)
        {
            PlayerMovement.speed = 0;
            PlayerMovement.jumpForce = 0;
            GameOverText.active = true;
            GameOverButton.active = true;
        }

    }
}
