using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swordBehaviorScript : MonoBehaviour {

    private Animator swordAnimator;
  
	// Use this for initialization
	void Start () {
        swordAnimator = GetComponent<Animator>();
	}

    // Update is called once per frame

    public void endAttacking()
    {
        Debug.Log("EndAttacking");
        swordAnimator.SetBool("attacking", false);
    }
    
}
