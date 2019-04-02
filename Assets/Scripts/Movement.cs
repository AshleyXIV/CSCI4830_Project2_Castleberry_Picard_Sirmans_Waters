using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    const int speed = 1;
    public Transform rig;
    void Start()
    {

    }

    
    void Update()
    {

        
        float moveHoriz = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        
        Vector3 position = rig.position;
        float relAngleF = Vector3.SignedAngle(transform.forward, Vector3.forward, Vector3.up);
        if ((relAngleF > 0f && relAngleF < 90f) || (relAngleF < 0f && relAngleF > -90f))
        {
            position.x += moveHoriz * speed * Time.deltaTime;
            position.z += -moveVertical * speed * Time.deltaTime;
        }
        else if ((relAngleF > 90f && relAngleF < 180f) || (relAngleF < -90f && relAngleF > -180f))
        {
            position.x += -moveHoriz * speed * Time.deltaTime;
            position.z += moveVertical * speed * Time.deltaTime;
        }
        rig.position = position;
        
    }
}