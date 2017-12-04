using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageRoomScript : MonoBehaviour {

    private GameObject[] fallingPlateforms;
    private Animator     rotatingPlateformAnimator;

	// Use this for initialization
	void Start () {
        rotatingPlateformAnimator = GameObject.FindGameObjectWithTag("rotatingPlateformRoom1").GetComponent<Animator>();
        fallingPlateforms         = GameObject.FindGameObjectsWithTag("FallingPlateform");
	}
	
    void OnTriggerEnter()
    {
        foreach (GameObject item in fallingPlateforms)
        {
            item.GetComponent<Rigidbody>().isKinematic = false;
            item.GetComponent<Rigidbody>().useGravity  = true;
            Destroy(item, 2f);
        }
        rotatingPlateformAnimator.SetBool("spawning", true);
    }
}
