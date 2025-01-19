using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{
    public GameObject DamageObject;

    void Start()
    {
        GetComponent<PlayerLives>();
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision DamageObject)
    {
        Debug.Log("lox");
        PlayerLives.Lives -= 1;
    
    }

}
