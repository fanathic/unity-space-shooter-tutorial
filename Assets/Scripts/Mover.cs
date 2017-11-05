﻿using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Mover : MonoBehaviour
{

    private Rigidbody _rb;

    public float speed;
	// Use this for initialization
	void Start ()
	{
	    _rb = GetComponent<Rigidbody>();
	    _rb.velocity = transform.forward * speed;
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
