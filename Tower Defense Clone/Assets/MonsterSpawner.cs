using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawner : MonoBehaviour
{
    public GameObject monsterPrefab;

 
    public float interval = 3;

  
    void Start()
    {
        InvokeRepeating("SpawnNext", interval, interval);
    }

    void SpawnNext()
    {
        Instantiate(monsterPrefab, new Vector3(6.75f, 0.5f, -12.73f), Quaternion.identity);
    }

    void Update()
    {
        
    }
}
