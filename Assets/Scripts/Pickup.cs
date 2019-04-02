using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public bool isPickedUp, wasPickedUo;
    public Transform whatGrabbedMe;
    Vector3 posOffset;
    Quaternion rotOffset;
    bool firstTest = true;
    public Transform oldT;
    // Start is called before the first frame update
    void Start()
    {
        isPickedUp = false;
        wasPickedUo = false;
        whatGrabbedMe = null;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (isPickedUp)
        {
            PickupBehavior(whatGrabbedMe);
            
                transform.position = whatGrabbedMe.localToWorldMatrix.MultiplyPoint(posOffset);
                transform.rotation = Quaternion.Inverse(transform.rotation) * rotOffset;
                GetComponent<Rigidbody>().velocity = (whatGrabbedMe.localToWorldMatrix.MultiplyPoint(posOffset) - transform.position) / Time.fixedDeltaTime;
                //float a; Vector3 x;
                //(whatGrabbedMe.rotation * rotOffset * Quaternion.Inverse(transform.rotation)).ToAngleAxis(out a, out x);
                //GetComponent<Rigidbody>().angularVelocity = (a * Mathf.Deg2Rad * x) / Time.fixedDeltaTime;
        }
        else
        {
            if (wasPickedUo) DropBehavior();
        }
    }

    void PickupBehavior(Transform t)
    {
        transform.position = t.position;
        rotOffset = Quaternion.Inverse(t.rotation) * transform.rotation;
        posOffset = t.worldToLocalMatrix.MultiplyPoint(transform.position);

        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<Rigidbody>().useGravity = false;
    }

    void DropBehavior()
    {
        wasPickedUo = false;
        GetComponent<Rigidbody>().isKinematic = false;
        GetComponent<Rigidbody>().useGravity = true;
        GetComponent<Rigidbody>().maxAngularVelocity = Mathf.Infinity;
        GetComponent<Rigidbody>().velocity = (oldT.localToWorldMatrix.MultiplyPoint(posOffset) - transform.position) / Time.fixedDeltaTime;
    }
}
