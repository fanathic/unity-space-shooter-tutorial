using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundary
{
    public float XMin, XMax, ZMin, ZMax;
}


public class PlayerController : MonoBehaviour
{
    public Boundary Boundary;
    private Rigidbody _rb;
    public float Speed = 10;
    public float Tilt;


// Use this for initialization
    private void Start ()
	{
	    _rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	private void FixedUpdate () {
	    float moveHorizontal = Input.GetAxis("Horizontal");
	    float moveVertical = Input.GetAxis("Vertical");

	    Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
	    _rb.velocity = movement * Speed;

        _rb.position = new Vector3(
            Mathf.Clamp(_rb.position.x, Boundary.XMin, Boundary.XMax),
            0.0f,
            Mathf.Clamp(_rb.position.z, Boundary.ZMin, Boundary.ZMax)
            );

	    _rb.rotation = (Quaternion.Euler(0.0f, 0.0f, _rb.velocity.x * -Tilt));
	}
}
