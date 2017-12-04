using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour {

	private void OnTriggerEnter(Collider other)
    {
        Debug.Log("onTrigger");
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("stayTrigger");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("exitTrigger");
    }
}
