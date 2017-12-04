using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour {

    public float SpeedRotation;
    public Transform CamTransform;
    private float rotationX = 0F;
    public float MaxXRotation = 250F;
    public float MinXRotation = 30F;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        float x = Input.GetAxis("Mouse X");
        float y = Input.GetAxis("Mouse Y");

       
       
        transform.eulerAngles += new Vector3(0, x, 0) * SpeedRotation;
        CamTransform.eulerAngles += new Vector3(-y, 0, 0) * SpeedRotation;
    }
}
