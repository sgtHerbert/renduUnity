using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class evenement : MonoBehaviour {

    private int repeat = 0;

    void OnCollisionEnter(Collision c)
    {
        Debug.Log(c.gameObject.name);
        if(c.gameObject.tag == "tagged_sphere") {
            repeat++;
            c.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, -500*repeat, 0));
            c.gameObject.GetComponent<Transform>().localPosition += new Vector3(0,5,0);
        }
    }
}
