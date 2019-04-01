using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public OVRInput.Controller rController;
    Vector2 rotateJoystick;
    public Rigidbody rig;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rotateJoystick = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick, rController);
        Rotate(rotateJoystick);
    }

    void Rotate(Vector2 value)
    {
        if (value.x != 0.0f) rig.transform.rotation = Quaternion.Euler(0, rig.transform.rotation.y + (value.x * 15f), 0);
    }
}
