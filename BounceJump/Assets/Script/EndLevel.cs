using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EndLevel : MonoBehaviour
{
    public bool TimerStop = true;
    public GameObject player;
    public GameObject EndLevelPad;

    
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
    }
}
