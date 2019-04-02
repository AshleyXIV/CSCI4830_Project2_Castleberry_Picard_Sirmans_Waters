using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl1Hand : MonoBehaviour
{
    public float pickupThreshold;
    public float releaseThreshold;
    public OVRInput.Controller mc;
    Lvl1Pickup currentPick = null;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerStay(Collider c)
    {
        Rigidbody rb = c.attachedRigidbody;

        if (rb == null)
        {
            return;
        }

        Lvl1Pickup p = rb.GetComponent<Lvl1Pickup>();

        if (p == null)
        {
            return;
        }

        float triggerVal;
        if (mc == OVRInput.Controller.LTouch)
        {
            triggerVal = OVRInput.Get(OVRInput.Axis1D.PrimaryIndexTrigger);
        }
        else
        {
            triggerVal = OVRInput.Get(OVRInput.Axis1D.SecondaryIndexTrigger);
        }

        if (currentPick == null && triggerVal > pickupThreshold)
        {
            currentPick = p;
            currentPick.pickedUp(this.transform);
        }

        if (currentPick != null && triggerVal < releaseThreshold)
        {
            currentPick.released(this.transform);
            currentPick = null;
        }



    }
}
