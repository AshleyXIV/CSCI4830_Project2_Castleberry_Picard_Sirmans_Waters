using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{

    const int speed = 1;
    public Transform origin;
    void Start()
    {

    }


    void Update()
    {


        float moveHorizontal = Input.GetAxis("Oculus_CrossPlatform_SecondaryThumbstickHorizontal");
        //float moveVertical = Input.GetAxis("Vertical");

        if (moveHorizontal != 0f)
        {
            Quaternion rotation = transform.rotation;
            rotation.y += moveHorizontal * speed * Time.deltaTime;
            //rotation.z += -moveVertical * speed * Time.deltaTime;
            transform.rotation = rotation;

            
            origin.rotation = rotation;
            transform.localRotation = new Quaternion(0, 0, 0, 0);
        }
    }
}