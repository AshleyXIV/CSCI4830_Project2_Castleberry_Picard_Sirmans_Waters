using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    const int speed = 1;
    public Transform origin;
    void Start()
    {

    }

    
    void Update()
    {

        
        float moveHoriz = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        if (moveHoriz != 0 || moveVertical != 0)
        {
            Vector3 position = transform.position;

            position.x += moveHoriz * speed * Time.deltaTime;
            position.z += -moveVertical * speed * Time.deltaTime;
            transform.position = position;
            origin.position = position;
            transform.localPosition = new Vector3(0, 0, 0);
        }
    }
}