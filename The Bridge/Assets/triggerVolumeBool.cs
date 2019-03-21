using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerVolumeBool : MonoBehaviour {
    public GameObject player;
    public bridgeyMakeWorkyPlease thingToTrigger;
    // Use this for initialization
    void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        MeshRenderer meshRend = GetComponent<MeshRenderer>();
        meshRend.material.color = Color.green; // make it green. 
        if (other.gameObject == player)
        {
            thingToTrigger.goBridgeGo = true;
        }
    }
}
