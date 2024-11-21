using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class EndLevel : MonoBehaviour
{
    public bool TimerStop = true;
    public GameObject player;
    public GameObject EndLevelPad;
    public GameObject YouWinText;
    public Button YouWinButton;

    
    void Start()
    {
        GetComponent<PlayerMovement>();
        GetComponent<Timer>();
        
    }

    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision EndLevelPad)
    { 
        PlayerMovement.speed = 0;
        PlayerMovement.jumpForce = 0;
        Timer.TimerStop = false;
        YouWinText.active = true;
        
    }
}
