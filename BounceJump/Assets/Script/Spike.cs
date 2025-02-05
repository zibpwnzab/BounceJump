using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{
    public GameObject DamageObject;
    public GameObject Player;
    public GameObject Spawnpoint;


    void Start()
    {
        GetComponent<PlayerLives>();
        GetComponent<PlayerRespawn>();
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision DamageObject)
    {
        PlayerLives.Lives -= 1;
        Player.transform.position = Spawnpoint.transform.position;
    }

}
