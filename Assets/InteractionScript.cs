using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionScript : MonoBehaviour {

    public string type ;
    public string name ;

    public void Interact(rayCast rayCastScript)
    {
        if (type == "spell") rayCastScript.SetSpell(this.name);
        else if (type == "weapon") rayCastScript.SetWeapon(this.name);
        else if (type == "answer") {
            GetComponent<Animator>().SetBool("press", true);
            if (name != "LaFaim")
                GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>().position = GameObject.FindGameObjectWithTag("Respawn").GetComponent<Transform>().position;
            else
            {
                GameObject.FindGameObjectWithTag("door2").GetComponent<Animator>().SetBool("open", true);
                GameObject.FindGameObjectWithTag("successSound").GetComponent<SuccessSoundManager>().playSound();
            }
        }       
    }

}
