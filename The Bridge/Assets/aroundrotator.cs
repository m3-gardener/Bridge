using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aroundrotator : MonoBehaviour {
    public bool bridgestart = false;
    public float speed = 1.0f;
    public Transform target;
    private int rotationCurrent;
    public bool directionInverted;
    // Use this for initialization
    void Start () {
        if (speed == 0)
            Debug.Log("ROTATOR SPEED CANNOT BE ZERO, DUMBASS. ");
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (bridgestart == true && !directionInverted)
        {
            rotationCurrent++;
            transform.RotateAround(target.position, Vector3.forward, speed);
        }
        if (bridgestart == true && directionInverted)
        {
            rotationCurrent++;
            transform.RotateAround(target.position, Vector3.back, speed);
        }
        if (rotationCurrent > 90 / speed)
        {
            bridgestart = false;
        }
    }
}
