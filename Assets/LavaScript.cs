using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaScript : MonoBehaviour
{
    private Vector3 spawnLocation;

    void Start()
    {
        spawnLocation = GameObject.FindGameObjectWithTag("Spawn").transform.position;
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Transform>().tag == "Player") {
            other.transform.position = spawnLocation;
        }
    }
}
