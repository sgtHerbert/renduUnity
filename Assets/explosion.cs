using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosion : MonoBehaviour {

    public float radius = 500.0F;
    public float power = 1000.0F;
    private List<GameObject> objectInRange;
    private float timer = 0;
    // Use this for initialization
    void Start () {
        objectInRange = new List<GameObject>();
    }
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;

        if (timer > 5)
        foreach( GameObject g in objectInRange)
        {
            g.GetComponent<Rigidbody>().AddForce( Vector3.Normalize(g.transform.position - transform.position) * 300);
        }
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Rigidbody>()) objectInRange.Add(other.gameObject);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<Rigidbody>()) objectInRange.Remove(other.gameObject);
    }
}
