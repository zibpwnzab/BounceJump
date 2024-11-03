using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public new Camera camera;
    public GameObject player;
    public float distance;

    public void Update()
    {

        camera.transform.position = player.transform.position;
        camera.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z + distance);
        

    }

}
