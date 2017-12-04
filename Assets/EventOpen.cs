using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventOpen : MonoBehaviour {

    public int speed = 1;
    public bool isopen = false;
    public bool openTheDoor = false;
    public Vector3 position;
    public Vector3 newposition;
    public int timer = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") timer = 1;//openTheDoor = true;
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("stayTrigger");
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player") Debug.Log("exit");

        //openTheDoor = false;
    }

    void Start()
    {
        position = transform.localPosition;
        newposition = new Vector3(transform.localPosition.x, transform.localPosition.y + transform.localScale.y, transform.localPosition.z);
    }


    void Update()
    {
        //if (openTheDoor && transform.localPosition != newposition)
        //{
        //    transform.localPosition = Vector3.Lerp(transform.localPosition, newposition, Time.deltaTime);
        //}
        //else if (!openTheDoor && transform.localPosition == newposition)
        //{
        //    transform.localPosition = Vector3.Lerp(transform.localPosition, position, Time.deltaTime);
        //}
        transform.localPosition = Vector3.Lerp(transform.localPosition, newposition, timer/*Time.deltaTime*/);
    }
}
