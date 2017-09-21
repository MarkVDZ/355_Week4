using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example2Player : MonoBehaviour {

    WheelJoint2D wheel;
    public float motorSpeed;

    // Use this for initialization
    void Start () {
        wheel = GetComponent<WheelJoint2D>();
        motorSpeed = 600;
	}
	
	// Update is called once per frame
	void Update () {
        float axisH = Input.GetAxis("Horizontal");

        JointMotor2D motor = wheel.motor;

        motor.motorSpeed = -axisH * motorSpeed;

        wheel.motor = motor;
        
	}

    public void TakeDamage()
    {
        print("!!!!!!!!!!!!!!!!!");
    }
}
