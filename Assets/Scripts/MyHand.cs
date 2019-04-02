using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyHand : MonoBehaviour
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
        if (c.GetComponent<Rigidbody>() == null) return;

        if (c.GetComponent<Rigidbody>() != null && c.attachedRigidbody.GetComponent<LightButton>() != null)
        {
            triggerVal = OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger, controller);

            if (triggerVal >= 0.75f)
            {

                if (c.attachedRigidbody.GetComponent<LightButton>().lightsAreOn) c.attachedRigidbody.GetComponent<LightButton>().lightsAreOn = false;
                else c.attachedRigidbody.GetComponent<LightButton>().lightsAreOn = true;
            }
        }

        else
        {
            return;
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