using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 3f;
    public float gravity = 9f;
    public float jumpSpeed = 15f;

    [Space]
    public CharacterController controller;

    private void Update()
    {
        Vector2 input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        bool jump = Input.GetKeyDown(KeyCode.Space);

        MovePlayer(input, jump);
    }

    Vector3 xzVelocity;
    Vector3 yVelocity;
    Vector3 playerFinalVel;

    bool isOnGround;
    private void MovePlayer(Vector2 input, bool jump)
    {
        xzVelocity = new Vector3(input.x, 0f, input.y) * moveSpeed * Time.deltaTime;
        if (!controller.isGrounded)
            yVelocity += Vector3.down * gravity * Time.deltaTime;
        else
            yVelocity = Vector3.zero;

        if (jump && isOnGround)
        {
            yVelocity += Vector3.up * jumpSpeed;
            isOnGround = false;
        }

        playerFinalVel = xzVelocity + yVelocity * Time.deltaTime;
        controller.Move(playerFinalVel);
    }
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        isOnGround = hit.gameObject.layer == LayerMask.NameToLayer("GroundObjects");

        if(hit.collider.tag == "Heart")
        {
            PlayerHealth.instance.AddHeart(hit.collider.gameObject);
        }
    }
}
