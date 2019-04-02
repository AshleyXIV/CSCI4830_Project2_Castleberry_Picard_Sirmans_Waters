using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    bool isHolding, canPickUp;
    Rigidbody obj;
    public OVRInput.Controller controller;
    float triggerVal, pickupThresh = 0.9f;
    Vector3 currVel;
    // Start is called before the first frame update
    void Start()
    {
        isHolding = false;
        canPickUp = false;
        obj = null;
    }

    // Update is called once per frame
    void Update()
    {
        currVel = this.GetComponent<Rigidbody>().velocity;
        
    }

    private void OnTriggerStay(Collider c)
    {
        if (c.attachedRigidbody.GetComponent<LightButton>() != null)
        {
            triggerVal = OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger, controller);

            if (triggerVal >= 0.75f)
            {

                if (c.attachedRigidbody.GetComponent<LightButton>().lightsAreOn) c.attachedRigidbody.GetComponent<LightButton>().lightsAreOn = false;
                else c.attachedRigidbody.GetComponent<LightButton>().lightsAreOn = true;
            }
        }

        else if (!isHolding && c.GetComponent<Pickup>() != null)
        {
            if (c.attachedRigidbody != null)
            {
                canPickUp = true;
                GetComponent<Renderer>().material.color = new Color(0, 1, 0, 0.45f);
            }


            if (canPickUp)
            {
                triggerVal = OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger, controller);

                if (triggerVal > pickupThresh)
                {
                    obj = c.attachedRigidbody;
                    obj.GetComponent<Pickup>().isPickedUp = true;
                    obj.GetComponent<Pickup>().whatGrabbedMe = this.transform;
                    isHolding = true;
                    canPickUp = false;
                    GetComponent<Renderer>().material.color = new Color(0, 0, 1, 0.45f);
                }
            }
        }
        else
        {

            triggerVal = OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger, controller);

            if (triggerVal < pickupThresh)
            {
                obj.GetComponent<Pickup>().oldT = this.transform;
                obj.GetComponent<Pickup>().wasPickedUo = true;
                isHolding = false;
                c.attachedRigidbody.isKinematic = false;
                obj.GetComponent<Pickup>().isPickedUp = false;
                obj.GetComponent<Pickup>().whatGrabbedMe = null;
                obj.transform.parent = null;
                obj = null;

                GetComponent<Renderer>().material.color = new Color(1, 1, 1, 0.45f);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
       

        if (canPickUp)
        {
            canPickUp = false;
            GetComponent<Renderer>().material.color = new Color(1, 1, 1, 0.45f);
        }
    }
}