using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllMove : CompentBehaviour
{
    [SerializeField] protected float moveSpeed = 5;
    [SerializeField] protected Rigidbody2D rb;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        rb = GetComponent<Rigidbody2D>();
    }
}
