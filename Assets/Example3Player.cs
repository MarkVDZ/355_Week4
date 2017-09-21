using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example3Player : MonoBehaviour
{

    CharacterController pawn;
    public float speedMove;
    public float speedTurn;
    Vector3 velocity = Vector3.zero;
    bool isJumping = false;
    public float impulseJump = 15;
    public float baseGravityMultiplier = 1;
    public float jumpGravityMultiplier = .5f;

    // Use this for initialization
    void Start()
    {
        pawn = GetComponent<CharacterController>();
        speedMove = 5;
        speedTurn = 180;

    }

    // Update is called once per frame
    void Update()
    {
        float axisV = Input.GetAxis("Vertical");
        float axisH = Input.GetAxis("Horizontal");

        transform.Rotate(0, axisH * speedTurn * Time.deltaTime, 0);
        Vector3 move = transform.forward * axisV * speedMove;
        velocity.x = move.x;
        velocity.z = move.z;

        float gravityScale = baseGravityMultiplier;
        if (pawn.isGrounded)
        {
            velocity.y = 0;
            if (Input.GetButtonDown("Jump"))
            {
                //move.y += 10;
                isJumping = true;
                velocity.y = impulseJump;
                gravityScale = jumpGravityMultiplier;
            }
        }
        else
        {
            if (Input.GetButton("Jump"))
            {
                if(isJumping == true && velocity.y > 0) gravityScale = jumpGravityMultiplier;
            }
            else
            {
                isJumping = false;
            }
        }
        velocity += Physics.gravity * Time.deltaTime * gravityScale;
        pawn.Move(velocity * Time.deltaTime);
    }
}
