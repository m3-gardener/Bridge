using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catapultcontrol : MonoBehaviour
{
    public Transform target;
    public bool controlapult = false;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("left")&& controlapult)
        {
            this.transform.RotateAround(target.position, Vector3.up, 1);
        }
        if (Input.GetKey("right")&& controlapult)
        {
            this.transform.RotateAround(target.position, Vector3.down, 1);
        }
    }
}
