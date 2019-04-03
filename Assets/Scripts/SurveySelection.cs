using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SurveySelection : MonoBehaviour
{
    public Transform pointer;
    public OVRInput.Controller c;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (OVRInput.Get(OVRInput.Axis1D.PrimaryIndexTrigger, c) >= 0.75)
        {
           
            RaycastHit h;
            if (Physics.Raycast(pointer.position, pointer.forward, out h, 20f))
            {
                
                
                    if (h.rigidbody.GetComponentInChildren<Button>() != null)
                    {
                        h.rigidbody.GetComponentInChildren<Button>().onClick.Invoke();
                        Debug.Log("d");
                    }
                    else Debug.Log("as");
                
            }
        }
    }
}
