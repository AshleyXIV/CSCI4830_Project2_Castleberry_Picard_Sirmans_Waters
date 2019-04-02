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

        position.x += moveHoriz * speed * Time.deltaTime;
        position.z += moveVertical * speed * Time.deltaTime;
        rig.position = position;
        
    }
}