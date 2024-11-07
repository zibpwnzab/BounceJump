using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YouWinText : MonoBehaviour
{
    public new Camera camera;
    public YouWinText text;
    public float distance;

    public void Update()
    {

        text.transform.position = camera.transform.position;
        text.transform.position = new Vector3(camera.transform.position.x, camera.transform.position.y, camera.transform.position.z + distance);


    }

}
