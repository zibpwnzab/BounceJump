using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeMovement : MonoBehaviour
{
    public GameObject Trigger1;
    public GameObject Trigger2;
    public GameObject MovingSpike;
    static public float speed = 3f;
    private Vector3 target;
    void Start()
    {
        target = Trigger1.transform.position;
    }

    void Update()
    {
        MovingSpike.transform.position = Vector3.MoveTowards(MovingSpike.transform.position, target, speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, target) < 0.1f)
        {
            target = (target == Trigger2.transform.position) ? Trigger1.transform.position : Trigger2.transform.position;
        }
    }
}
