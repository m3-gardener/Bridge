using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bridgeyMakeWorkyPlease : MonoBehaviour {
    public bool goBridgeGo = false;

    public aroundrotator[] thingsToRotate;
    public BitMover[] thingsToMove;


    // Use this for initialization
    void Start ()
    {

    }
	
	// Update is called once per frame
	void Update () {
        if (goBridgeGo == true)
        {
            int numberOfThingsToMove = thingsToMove.Length;
            for (int i = 0; i < numberOfThingsToMove; i++)
            {
                thingsToMove[i].bridgestart = true; // remeber it's an array so you need an "i" in brackets
            }
            int numberOfThingsToRotate = thingsToRotate.Length;
            for (int i = 0; i < numberOfThingsToRotate; i++)
            {
                thingsToRotate[i].bridgestart = true;
            }
            goBridgeGo = false;
        }
	}
}
