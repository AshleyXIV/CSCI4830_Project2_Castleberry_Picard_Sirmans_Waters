using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightButton : MonoBehaviour
{
    public Lights lights;
    public bool lightsAreOn;
    // Start is called before the first frame update
    void Start()
    {
        if (!lights.isOptional)
            lightsAreOn = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (lights.isActiveAndEnabled && !lightsAreOn) lights.gameObject.SetActive(false);
        if (!lights.isActiveAndEnabled && lightsAreOn) lights.gameObject.SetActive(true);

        /*if(lightsAreOn == false)
        {
            lights.gameObject.SetActive(true);
        }
        else
        {
            lights.gameObject.SetActive(false);
        }*/
    }
}
