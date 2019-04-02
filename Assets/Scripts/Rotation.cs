using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{

    const int speed = 1;

    void Start()
    {

    }


    void Update()
    {


        float moveHorizontal = Input.GetAxis("Oculus_CrossPlatform_SecondaryThumbstickHorizontal");
        //float moveVertical = Input.GetAxis("Vertical");


        Quaternion rotation = transform.rotation;
        rotation.y += moveHorizontal * speed * Time.deltaTime;
        //rotation.z += -moveVertical * speed * Time.deltaTime;
        transform.rotation = rotation;

    }
}