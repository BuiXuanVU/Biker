using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePointCtrl : CompentBehaviour
{
    public static MovePointCtrl instance;
    [SerializeField] private List<Transform> spawnPoint;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        if(spawnPoint == null)
        {
            for(int i = 0; i < 2; i++)
            {
                spawnPoint.Add(transform.GetChild(i));
            }
        }
    }
    protected override void Awake()
    {
        base.Awake();
        instance = this;
    }
    public Vector3 GetSpawnPoint(int Point)
    {
        return spawnPoint[Point].position;
    }
}
