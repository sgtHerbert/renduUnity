using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// implement InterfaceBehavior, fournissant la fonction Freez pour chaque objet affecté par un sort
public class PlateformBehaviorScript : MonoBehaviour, InterfaceBehavior {

    private Animator animator;

    public void Freeze()
    {
        animator.SetBool("freeze", true);
        GetComponent<MeshRenderer>().material.color = Color.white;
    }

    // Use this for initialization
    void Start () {
        animator = GetComponent<Animator>();	
	}
	
}
