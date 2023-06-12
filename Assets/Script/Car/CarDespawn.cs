using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarDespawn : MonoBehaviour
{
    private void Update()
    {
        if(transform.position.x <= -25 || transform.position.x >= 29)
        {
            CarSpawn.instance.Despawn(transform);
        }
    }
}
