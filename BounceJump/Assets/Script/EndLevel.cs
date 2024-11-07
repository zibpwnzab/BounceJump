using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevel : MonoBehaviour
{
    public GameObject player;
    public GameObject EndLevelPad;

    void Start()
    {
        PlayerMovement = This.GetComponent<PlayerMovement>();
    }

    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision EndLevelPad)
    {
    
    }
}
