using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawn : CompentBehaviour
{
    public static CarSpawn instance;
    [SerializeField] private List<Transform> carPool;
    [SerializeField] private List<Transform> CarPrefab;
    private float lastTime;
    private float timeDelay;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        if(CarPrefab == null)
        {
            for(int i = 0; i < 2; i++)
            {
                CarPrefab.Add(transform.GetChild(i));
            }
        }
    }
    protected override void Awake()
    {
        base.Awake();
        instance = this;
    }
    private void Update()
    {
        if (Time.time - lastTime >= timeDelay)
        {
            timeDelay = Random.Range(8, 16);
            lastTime = Time.time;
            SpawnCar();
        }
    }
    private void SpawnCar()
    {
        int pointNumber = Random.Range(0, 2);
        string newCarTag = GetCarPrefab();
        Transform newCar = GetObjFromPool(newCarTag);
        carDirection(newCar, pointNumber);
        newCar.position = MovePointCtrl.instance.GetSpawnPoint(pointNumber);
        newCar.gameObject.SetActive(true);
    }
    private Transform GetObjFromPool(string carTag)
    {
        foreach (Transform obj in carPool)
        {
            if (obj.tag == carTag)
            {
                carPool.Remove(obj);
                return obj;
            }
        }
        return SpawnNewCar(carTag);
    }
    private Transform SpawnNewCar(string carTag)
    {
        Transform newCar = Instantiate(GetPrefab(carTag));
        newCar.tag = carTag;
        return newCar;
    }
    private Transform GetPrefab(string carTag)
    {
        foreach (Transform car in CarPrefab)
        {
            if (car.tag == carTag)
            {
                return car;
            }
        }
        return null;
    }
    private void carDirection(Transform car, int point)
    {
        Vector3 localScale = car.localScale;
        if (point == 0)
            localScale.x = 5;
        else
            localScale.x = -5;
        car.localScale = localScale;
    }
    private string GetCarPrefab()
    {
        int carNumber = Random.Range(0, CarPrefab.Count);
        return CarPrefab[carNumber].tag;
    }
    public void Despawn(Transform car)
    {
        carPool.Add(car);
        car.gameObject.SetActive(false); 
    }
}
