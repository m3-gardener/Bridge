using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraDynamicSwitch : MonoBehaviour {

    // Use this for initialization
    public Camera mainCam;
    public Camera triggerdCam;
    public GameObject player;

    void Start()
    {
       
            triggerdCam = gameObject.GetComponentInChildren(typeof(Camera)) as Camera;
            player = GameObject.FindGameObjectWithTag("Player");
            triggerdCam.enabled = false;

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {

            mainCam.enabled = false;
            triggerdCam.enabled = true;
        }
        }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == player)
        {
            mainCam.enabled = true;
            triggerdCam.enabled = false;
        }
    }

}