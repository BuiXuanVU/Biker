using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColliderCtrl : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameOverManager.Instance.GameOver();
    }
}
