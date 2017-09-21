using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example1Player : MonoBehaviour {

    Rigidbody body;
    public float impulseJump = 5;
    public float torqueScaler = 10;

    // Use this for initialization
    void Start () {
        body = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {

        float axisH = Input.GetAxis("Horizontal");
        body.AddTorque(Vector3.forward * axisH * -1 * torqueScaler);

        if (Input.GetButtonDown("Jump"))
        {
            body.AddForce(transform.up * impulseJump, ForceMode.Impulse);
        }
        
    }
}
