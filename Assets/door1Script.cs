using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door1Script : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Transform>().tag == "Player"){
            //on verifie que le joueur a bien récupérer le sort
            if (other.GetComponent<rayCast>().hasSpell())
            { 
                this.GetComponent<Animator>().SetBool("open", true);
                GameObject.FindGameObjectWithTag("successSound").GetComponent<SuccessSoundManager>().playSound();
                Destroy(this, 1f);
            }
        }
    }
}
