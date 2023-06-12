using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogAnimation : CompentBehaviour
{
    private Vector2 lastPoint;
    [SerializeField] private Animator animator;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        GetPoint();
    }
    private void GetPoint()
    {
        float xPos = transform.parent.position.x - lastPoint.x;
        float yPos = transform.parent.position.y - lastPoint.y;
        lastPoint = transform.parent.position;
        if(yPos != 0)
        {
            if(yPos > 0.01)
                animator.SetFloat("Vertical", 1);
            if (yPos < -0.01)
                animator.SetFloat("Vertical", -1);
           if (yPos >= -0.01 && yPos <= 0.01)
              animator.SetFloat("Vertical", 0);
        }   
        if (xPos != 0)
        {
            if (xPos > 0.01)
                animator.SetFloat("Horizontal", 1);
            if (xPos < -0.01)
                animator.SetFloat("Horizontal", -1);
            if (xPos >= -0.01 && xPos <= 0.01)
              animator.SetFloat("Horizontal", 0);
        }    
    }    
}
