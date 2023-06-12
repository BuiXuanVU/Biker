using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMain : AllMove
{
    private Vector2 moveDirection;
    private void Update()
    {
        GetDirection();
    }
    private void FixedUpdate()
    {
        Move();
    }
    private void GetDirection()
    {
        moveDirection.x = Input.GetAxisRaw("Horizontal");
        moveDirection.y = Input.GetAxisRaw("Vertical");
    } 
    private void Move()
    {
        Vector2 pos = rb.position;
        pos.x = Mathf.Clamp(pos.x, -13, 26);
        pos.y = Mathf.Clamp(pos.y, -2.8f, 3.9f);
        rb.MovePosition(pos + moveDirection * moveSpeed * Time.deltaTime);
        PlayerAnimation.instance.DoAnimation(moveDirection);
    }    
}
