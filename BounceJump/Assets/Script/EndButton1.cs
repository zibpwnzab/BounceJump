using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EndButton1 : MonoBehaviour
{
    public Button Button;
    public GameObject Player;
    public GameObject YouWinText;
    public GameObject TextTimer;
    public GameObject ButtonOff;
   
    
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


    void OnButtonClick()
    {
        PlayerMovement.speed = 6f;
        PlayerMovement.jumpForce = 9f;
        Player.transform.position = new Vector3(95, 6 ,-4.87f);
        YouWinText.active = false;
        TextTimer.active = false;
        ButtonOff.active = false;
        Timer.startTime = Time.time;
        Timer.TimerStop = true;


    }
}
