using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    const int speed = 1;
    
    void Start()
    {

    }

    
    void Update()
    {

        
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        
        Vector3 position = transform.position;
        position.x += moveHorizontal * speed * Time.deltaTime;
        position.z += -moveVertical * speed * Time.deltaTime;
        transform.position = position;

    }
}