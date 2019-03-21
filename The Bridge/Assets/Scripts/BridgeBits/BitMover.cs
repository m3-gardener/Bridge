using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BitMover : MonoBehaviour
{
    public bool bridgestart = false;
    public int transformdistance = 100;
    public float speed = 1.0f;
    public Transform target;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (bridgestart == true) {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        }
        if (Vector3.Distance(transform.position, target.position) < 0.001f)
        {
            bridgestart = false;
        }
    }

    private void FixedUpdate()
    {
    }
}