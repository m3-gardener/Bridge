using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballFlight : MonoBehaviour {
    public bool ready2fire = false;
    public int launchPower = 1000;
    public GameObject myGameObject;
    // Use this for initialization
    void Start()
    { 
        
    }
	
	// Update is called once per frame
	void Update () {
        if (ready2fire)
        {
            this.transform.parent = null;
            Rigidbody gameObjectsRigidBody = myGameObject.AddComponent<Rigidbody>();
            gameObjectsRigidBody.mass = 1;
            gameObjectsRigidBody.useGravity = true;
            Debug.Log("BE ADVISED. LAUNCH POWER AT: " + launchPower);
            for (int i = 0; i < launchPower; i++)
            {
                gameObjectsRigidBody.AddForce(transform.forward);
            }
            ready2fire = false;

        }
    }
}
