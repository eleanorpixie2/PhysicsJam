using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SpawnerScript : MonoBehaviour
{
    [SerializeField]
    float SpawnRate = 1f;

    [SerializeField]
    int MaxSpawnAmount = 3;

    public float TimeBetweenWaves=3;

    private int currentSpawnAmount;
    private int spawnWave;
    private bool EndOfWave;

    float CurrentSpawnrate;
    public List<GameObject> ApplesLists;

    // Start is called before the first frame update
    void Start()
    {
        currentSpawnAmount = 0;
        spawnWave = 1;
        EndOfWave = false;
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
        if(currentSpawnAmount==MaxSpawnAmount&&!EndOfWave)
        {
            EndOfWave = true;
            spawnWave++;
            StartCoroutine(NewWave());
        }
    }

    void Spawn()
    {
            System.Random rnd = new System.Random(Guid.NewGuid().GetHashCode());
        if (currentSpawnAmount < MaxSpawnAmount)
        {
            //apples
            if (spawnWave == 1)
            {
                Instantiate(ApplesLists[0], transform);
                currentSpawnAmount++;
            }
            //apples,chick
            else if (spawnWave == 2)
            {
                int i = rnd.Next(0, 1);
                Instantiate(ApplesLists[i], transform);
                currentSpawnAmount++;
            }
            //apples,chick,chicken
            else if (spawnWave == 3)
            {
                int i = rnd.Next(0, 2);
                Instantiate(ApplesLists[i], transform);
                currentSpawnAmount++;
            }
            //apples,chick,chicken,cow
            else if (spawnWave == 4)
            {
                int i = rnd.Next(0, 3);
                Instantiate(ApplesLists[i], transform);
                currentSpawnAmount++;
            }
            //apples,chick,chicken,cow,peach
            else if (spawnWave == 5)
            {
                int i = rnd.Next(0, 4);
                Instantiate(ApplesLists[i], transform);
                currentSpawnAmount++;
            }
            //apples,chick,chicken,cow,peach,pear
            else if (spawnWave == 6)
            {
                int i = rnd.Next(0, 5);
                Instantiate(ApplesLists[i], transform);
                currentSpawnAmount++;
            }
            //apples,chick,chicken,cow,peach,pear,pig
            else
            {
                int i = rnd.Next(0, ApplesLists.Count);
                Instantiate(ApplesLists[i], transform);
                currentSpawnAmount++;
            }
        }
    }

    IEnumerator NewWave()
    {
        yield return new WaitForSeconds(TimeBetweenWaves);
        currentSpawnAmount = 0;
        EndOfWave = false;
    }
}
