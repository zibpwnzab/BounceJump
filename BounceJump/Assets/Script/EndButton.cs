using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EndButton : MonoBehaviour
{
    public Button Button;
    public GameObject Player;
   
    
    void Start()
    {
        GetComponent<PlayerMovement>();
        GetComponent<Timer>();
        if (Button != null && Player != null)
        {
            Button.onClick.AddListener(OnButtonClick);
        }

    }


    void Update()
    {
        
        

        
    }


    public void OnButtonClick()
    {
        PlayerMovement.speed = 6f;
        PlayerMovement.jumpForce = 9f;
        Timer.startTime = Time.time;
        Timer.TimerStop = true;
        Debug.Log("Button is Pressed");


    }
}
