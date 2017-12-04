using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rayCast : MonoBehaviour {

    private Component    cam;
    public  Transform    LaserParticules;

    private float     interactionDistance = 7;
    private GameObject weaponGameObject;
    private Animator   weaponAnimator;
    private GameObject spellGameObject;
    private Animator   spellAnimator;
    private RaycastHit freezableObject;
    private bool       focusingFreezableObject;

    public bool hasSpell()
    {
        return spellGameObject.activeSelf;
    }

    public void SetSpell(string spellName)
    {
        spellGameObject.SetActive(true);
    }

    public void SetWeapon(string weaponName)
    {
        weaponGameObject.SetActive(true);
    }

    // Use this for initialization
    void Start () {
        spellGameObject = GameObject.FindGameObjectWithTag("PlayerSpell");
        spellAnimator = GameObject.FindGameObjectWithTag("PlayerSpell").GetComponent<Animator>();
        spellGameObject.SetActive(false);
        // weapon activation
        weaponGameObject = GameObject.FindGameObjectWithTag("PlayerWeapon");
        weaponAnimator = GameObject.FindGameObjectWithTag("PlayerWeapon").GetComponent<Animator>();
        weaponGameObject.SetActive(false);
        //freezableObject
    }

	// Update is called once per frame
	void FixedUpdate() {

        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            if (hit.transform.tag == "InteractionObject" && interactionDistance >= Vector3.Distance(transform.localPosition, hit.point))
            {

                if (Input.GetKey(KeyCode.E))
                {
                    hit.collider.GetComponent<InteractionScript>().Interact(this);
                }

            }
            else if (hit.transform.tag == "rotatingPlateformRoom1" || hit.transform.tag == "rotatingPlateformRoom2" || hit.transform.tag == "projectile"){
                freezableObject  = hit;
                focusingFreezableObject = true;
            }
            else
            {
                focusingFreezableObject = false;
            }
        }

        if (spellGameObject.activeSelf && Input.GetKey(KeyCode.Mouse0) && focusingFreezableObject == true )
        {
            spellAnimator.SetBool("attacking", true);
            freezableObject.transform.GetComponent<PlateformBehaviorScript>().Freeze();
        }
        if (Input.GetKey(KeyCode.Mouse1))
        {
            weaponAnimator.SetBool("attacking", true);
        }
    }
}


/*NavmeshHit
    Vector3 RandomeDirection = Random.InsideUnitSHpere * Distance;
    randomeDirection += transform.position;
    NavMeshHit hit;
    NavMesh.SamplePosition(randomDirection,out hit, Distance, 1);
    Vector3 finalPosition = hit.position;
    GetComponent<NavMeshAgent>().destination = finalPosition;

*/
