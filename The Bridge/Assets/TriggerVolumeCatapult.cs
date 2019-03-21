using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerVolumeCatapult : MonoBehaviour {

        public GameObject player;
        public PlayerMovement playerMover;
        public CatapultAnimator catapultShooter;
        public Catapultcontrol catapultAimer;
        public bool triggerToggled = false;
        public GameObject object1;
        public GameObject object2;
    // Use this for initialization
    void Start()
        {
            player = GameObject.FindGameObjectWithTag("Player");
        }

        // Update is called once per frame
        void Update()
        {

        }
        private void OnTriggerStay(Collider other)
        {
        if (Input.GetKeyDown("space"))
        {
            MeshRenderer meshRend = GetComponent<MeshRenderer>();
            triggerToggled = !triggerToggled;
            if (triggerToggled)
            {
                meshRend.material.color = Color.green; // make it green.
                if (other.gameObject == player)
                {
                    playerMover.controlHandoff = true;
                    catapultShooter.controlHandoff = true;
                    catapultAimer.controlapult = true;
                    
                    Debug.Log("Player controls catapult");
                    object1.transform.parent = object2.transform;
                }
            }
            if (!triggerToggled)
            {
                meshRend.material.color = Color.white;
                playerMover.controlHandoff = false;
                catapultShooter.controlHandoff = false;
                catapultAimer.controlapult = false;
                Debug.Log("Player stops controling catapult");
            }
        }
        
        }
    }
