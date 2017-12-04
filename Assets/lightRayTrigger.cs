using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightRayTrigger : MonoBehaviour {

    private Animator     lightAnimator;
    private LineRenderer light; 

    void Start()
    {
        lightAnimator = GetComponent<Animator>();
        light         = GetComponent<LineRenderer>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            light.widthMultiplier = 1;
            lightAnimator.SetBool("playerEnter", true);
        }
    }
}
