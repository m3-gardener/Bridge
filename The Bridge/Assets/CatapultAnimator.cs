using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatapultAnimator : MonoBehaviour {
    private bool readytofire;
    private float rotationCurrent;
    public float speed = 1.0f;
    private int power = 0;
    public bool controlHandoff = false;
    public ballFlight balltolaunch;
    private bool launchit;
    private bool foundValidBall = false;
    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void FixedUpdate()
    {
        if (foundValidBall == false)
        {
            GameObject checkchildren = this.gameObject.transform.GetChild(0).GetChild(0).gameObject;
            if (checkchildren = GameObject.FindGameObjectWithTag("projectile"))
            {
                foundValidBall = true;
                balltolaunch = checkchildren.GetComponent("ballFlight") as ballFlight; // this badass mofo right here gets the ball code, from the ball, after checking if a ball is attached. It's pretty neat, huh?
                Debug.Log("FOUND PROJECTILE " + balltolaunch);
            }
            else
            {
                Debug.Log("Didn't find projectile");
                foundValidBall = false;
            }
        }
        if (Input.GetKey("up") && controlHandoff)
        {
           power++;
           this.transform.Rotate(0,speed, 0);
           launchit = true;
        }
        else
        {
            if (power > 0)
            {
                if (power < 40 && power > 35)
                { // a short window to fire the projectile.
                    balltolaunch.ready2fire = true;
                    Debug.Log("ready");
                }
                
                if (launchit == true)
                {
                    balltolaunch.launchPower = power*10;
                }
                power = power -4;
                launchit = false;
                this.transform.Rotate(0, -speed*4, 0);
               
            }
        }
        
    }
    
}
