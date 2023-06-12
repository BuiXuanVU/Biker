using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : CompentBehaviour
{
    public static PlayerAnimation instance;
    [SerializeField] private Animator playerAnimator;
    private bool look = true;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        playerAnimator = GetComponent<Animator>();
    }
    protected override void Awake()
    {
        base.Awake();
        instance = this;
    }
    public void DoAnimation(Vector2 Direction)
    {
        playerAnimator.SetFloat("Speed",Direction.sqrMagnitude);
        playerAnimator.SetFloat("Vertical", Direction.y);
        if(Direction.x != 0)
        {
            if(look && Direction.x < 0 || !look && Direction.x > 0)
            {
                look = !look;
                Vector3 localscale = transform.localScale;
                localscale.x *= -1;
                transform.localScale = localscale;
            }    
            playerAnimator.SetFloat("Horizontal", 1);
        }    
        else if(Direction.x == 0)
            playerAnimator.SetFloat("Horizontal", 0);
    }
}
