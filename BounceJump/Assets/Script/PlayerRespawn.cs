using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    public GameObject Respawn;
    public GameObject Player;




    void Start()
    {
        DoRespawn();
    }


    void Update()
    {
        
 
    }

    private void DoRespawn()
    {
        Player.transform.position = Respawn.transform.position;
    }
}
