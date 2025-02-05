using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddLives : MonoBehaviour
{

    public GameObject Player;
    public GameObject BallOfLife;
    void Start()
    {
        GetComponent<PlayerLives>();
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision LiveBall)
    {
        PlayerLives.Lives += 1;
        Destroy(BallOfLife);
    }



}
