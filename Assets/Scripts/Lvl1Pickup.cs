﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl1Pickup : MonoBehaviour
{
    public Transform holder;
    public Rigidbody rb;
    private Vector3 posHolder; //local
    private Quaternion rotOffset; // local

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (holder != null)
        {
            this.transform.position = holder.localToWorldMatrix.MultiplyPoint(posHolder);
            this.transform.rotation = holder.transform.rotation;
        }
    }

    public void pickedUp(Transform t)
    {
        posHolder = t.worldToLocalMatrix.MultiplyPoint(this.transform.position);
        rb.isKinematic = true;
        holder = t;

    }

    public void released(Transform t)
    {
        if (t = holder)
        {
            rb.isKinematic = false;
            holder = null;
        }
    }

}