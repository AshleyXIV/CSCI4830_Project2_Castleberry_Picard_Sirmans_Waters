using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyHand : MonoBehaviour
{
    public OVRInput.Controller c;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.GetComponent<LightButton>() != null)
        {
            if (OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger, c) >= 0.75f)
            {
                if (other.GetComponent<LightButton>().lightsAreOn) other.GetComponent<LightButton>().lightsAreOn = false;
                else other.GetComponent<LightButton>().lightsAreOn = true;
            }
                
        }
    }
}
