using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellBehaviorScript : MonoBehaviour {

    private Animator spellAnimator;

    // Use this for initialization
    void Start()
    {
        spellAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame

    public void endAttacking()
    {
        Debug.Log("EndAttacking");
        spellAnimator.SetBool("attacking", false);
    }
}
