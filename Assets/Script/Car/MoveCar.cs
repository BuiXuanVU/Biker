using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCar : AllMove
{
    private void FixedUpdate()
    {
        if (transform.localScale.x > 0)
            CarLeftMove();
        else
            CarRightMove();
    }
    private void CarLeftMove()
    {
        rb.velocity = Vector3.left * moveSpeed;
    }
    private void CarRightMove()
    {
        rb.velocity = Vector3.right * moveSpeed;
    }
}
