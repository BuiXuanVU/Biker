using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] private Transform player;
    private void Update()
    {
        MoveToPlayer();
    }
    private void MoveToPlayer()
    {
        Vector3 tagetPos = player.position;
        tagetPos.x = Mathf.Clamp(tagetPos.x,0,13);
        tagetPos.y = 0;
        tagetPos.z = -10;
        transform.position = Vector3.LerpUnclamped(transform.position,tagetPos,10 * Time.deltaTime);
    }    
}
