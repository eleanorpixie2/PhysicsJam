using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SpawnerScript : MonoBehaviour
{
    [SerializeField]
    float SpawnRate = 1f;
    [SerializeField]
    Rigidbody2D rbSpawner;
    [SerializeField]
    GameObject Apples;
    [SerializeField]
    int MaxSpawnAmount = 5;

    float CurrentSpawnrate;
    public List<GameObject> ApplesLists;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 1, SpawnRate);
        CurrentSpawnrate = SpawnRate;
    }

    // Update is called once per frame
    void Update()
    {
        if (CurrentSpawnrate != SpawnRate)
        {
            CurrentSpawnrate = SpawnRate;
            CancelInvoke();
            InvokeRepeating("Spawn", 1, SpawnRate);
        }
    }

    void Spawn()
    {
            System.Random rnd = new System.Random(Guid.NewGuid().GetHashCode());
            int i = rnd.Next(0, ApplesLists.Count);
            Instantiate(ApplesLists[i], rbSpawner.transform);
    }
}
