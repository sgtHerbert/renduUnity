using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouvement : MonoBehaviour {
    public int      Speed;
    public float    SpeedMax;
    public int      JumpPower;

    private bool        canJump = false;
    private Rigidbody   body;
    private bool        moving  = false;
    // Use this for initialization
    void Start () {
        body = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        if (body.velocity.magnitude < SpeedMax) {

            // à part pour le saut on supprime annule toute force pour ne pas avoir de poussé au moment de bouger
            if (Input.GetKey(KeyCode.Z) && canJump)
            {
                body.velocity = new Vector3(0, body.velocity.y, 0);
                body.AddForce(transform.forward * SpeedMax);
                moving = true;
            }
            if (Input.GetKey(KeyCode.S) && canJump) {
                body.velocity = new Vector3(0, body.velocity.y, 0);
                body.AddForce(transform.forward * -(SpeedMax/1.5f));
                moving = true;
            };
            if (Input.GetKey(KeyCode.Q) && canJump)
            {
                body.velocity = new Vector3(0, body.velocity.y, 0);
                body.AddForce(transform.right * -SpeedMax);
                moving = true;
            }
            if (Input.GetKey(KeyCode.D) && canJump) {
                body.velocity = new Vector3(0, body.velocity.y, 0);
                body.AddForce(transform.right * SpeedMax);
                moving = true;
            }
        }
        else
            moving = true;

        if (Input.GetKeyDown(KeyCode.Space) && canJump)
        {
            body.velocity = new Vector3(body.velocity.x, 0, body.velocity.z);
            body.AddForce(new Vector3(0, JumpPower, 0));
            moving = true;
        }

        if (canJump && !moving)
            body.velocity = new Vector3(0, body.velocity.y, 0);
        if (!canJump && transform.up.magnitude != 0)
            body.AddForce(new Vector3(0, -JumpPower / 70, 0));

        moving  = false;
        canJump = false;
    }

    private void OnTriggerStay(Collider other)
    {
        canJump = true;
    }

}
