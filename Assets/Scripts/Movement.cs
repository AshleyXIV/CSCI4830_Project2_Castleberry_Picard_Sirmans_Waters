using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public OVRInput.Controller controller;
    Vector2 moveJoystick;
    public OVRInput.Controller rController;
    Vector2 rotateJoystick;
    Vector3 currentPos;
    Quaternion currentRot;
    public Transform rig;
    // Start is called before the first frame update
    void Start()
    {
        currentPos = rig.position;
        currentRot = rig.rotation;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        

        moveJoystick = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick, controller);
        rotateJoystick = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick, rController);
        if (moveJoystick != Vector2.zero)
        {
            rig.position += Move(moveJoystick);
            currentPos = rig.position;
        }
        if (rotateJoystick.x != 0.0f)
        {
            rig.rotation *= Rotate(rotateJoystick);
            currentRot = rig.rotation;
        }
    }

    Vector3 Move(Vector2 value)
    {
        Vector3 pos = new Vector3((value.x * 0.05f), 0f, (value.y * 0.05f));
        return pos;
    }

    Quaternion Rotate(Vector2 value)
    {
        Quaternion rot = Quaternion.Euler(0, value.x * 2, 0);
        return rot;
    }
}
