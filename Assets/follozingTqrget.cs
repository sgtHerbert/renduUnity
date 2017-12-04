using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follozingTqrget : MonoBehaviour {

    public Transform target;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.localPosition = Vector3.Lerp(transform.localPosition, target.localPosition, 0.01f/*Time.deltaTime*/);
    }
}
