using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    
    public float speedDampTime = 0.01f;
    public float sensitivityX = 1.0f;
    public bool controlHandoff = false;

    private Animator anim;
    private HashIDs hash;

    private void Awake()
    {
            anim = GetComponent<Animator>();
            hash = GameObject.FindGameObjectWithTag("GameController").GetComponent<HashIDs>();
            anim.SetLayerWeight(0, 1f);

            // Quaternion fixRotation = Quaternion.Euler(0f, -90f, 0f);
            //  Rigidbody ourBody = this.GetComponent<Rigidbody>();
            // ourBody.MoveRotation(fixRotation);
    }

    private void FixedUpdate()
    {
        if (!controlHandoff)// checks to ensure the player isn't supposed to be controlling something else.
        {
            float v = Input.GetAxis("Vertical");
            float desiredX = Input.GetAxis("Horizontal");

            Rotating(desiredX);
            MovementManager(v);
        }
    }
    private void Update()
    {
        

    }
    void MovementManager(float vertical)
    {
        if (vertical > 0 && !controlHandoff)
        {
            anim.SetFloat(hash.speedFloat, 1.5f, speedDampTime, Time.deltaTime);
        }
        else
        {
            anim.SetFloat(hash.speedFloat, 0);
        }
    }

    void Rotating(float XInput)
    {
        Rigidbody ourBody = this.GetComponent<Rigidbody>();

        if (XInput != 0 && !controlHandoff)
        {
            Quaternion deltaRotation = Quaternion.Euler(0f, XInput * sensitivityX, 0f);

            ourBody.MoveRotation(ourBody.rotation * deltaRotation);

        }
    }
    void AudioManagement ()
    {
        if (!controlHandoff)// checks to ensure the player isn't supposed to be controlling something else.
        {
            if (anim.GetCurrentAnimatorStateInfo(0).IsName("Walk") && !controlHandoff)
            {
                if (!GetComponent<AudioSource>().isPlaying)
                {
                    GetComponent<AudioSource>().pitch = 0.27f;
                    GetComponent<AudioSource>().Play();
                }
            }
            else
            {
                GetComponent<AudioSource>().Stop();
            }
        }
    }
}
