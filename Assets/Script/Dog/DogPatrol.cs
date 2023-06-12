using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogPatrol : AllMove
{
    [SerializeField] protected Transform direction1;
    [SerializeField] protected Transform direction2;
    protected Transform targetPosition;
    protected override void Start()
    {
        base.Start();
        targetPosition = this.direction1;
    }
    private void Update()
    {
        Vector2 point = targetPosition.position - transform.position;
        transform.position = Vector3.MoveTowards(transform.position, targetPosition.position, moveSpeed * Time.deltaTime);
        if (Vector2.Distance(transform.position, targetPosition.position) < 0.75f && targetPosition == this.direction2)
        {
            targetPosition = this.direction1;
        }
        if (Vector2.Distance(transform.position, targetPosition.position) < 0.75f && targetPosition == this.direction1)
        {
            targetPosition = this.direction2;
        }
    }
}
