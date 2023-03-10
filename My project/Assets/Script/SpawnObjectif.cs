using System.Collections;
using System.Collections.Generic;
using Engine.Utils;
using UnityEngine;


public class SpawnObjectif : Singleton<SpawnObjectif>
{
    [SerializeField]
    private GameObject objectif;

    [SerializeField]
    private List<Transform> spawnPoints;

    [SerializeField]
    private SkyManager skyTransform;

    SpawnZone spawnZones;

    int previousSpawnZone;
    Transform LastSpawn;
    Transform NewSpawn;
    // Start is called before the first frame update
    protected override void Start()
    {
        Spawn();
        base.Start();
    }

    public void Spawn()
    {
        NewSpawn = spawnPoints[Random.Range(0, spawnPoints.Count)];
        if(LastSpawn!= null)
        {
            spawnPoints.Add(LastSpawn);

            //Debug.Log(skyManager);
            skyTransform.AreaVisited(LastSpawn.gameObject.tag);
        }
        
        Transform randomSpawn = NewSpawn;
        spawnPoints.Remove(NewSpawn);

        GameObject instantied = Instantiate(objectif);
        spawnZones = GetComponentInChildren<SpawnZone>();
        instantied.transform.position = new Vector3(
                Random.Range(randomSpawn.position.x - spawnZones.spawnSize.x / 2, randomSpawn.position.x + spawnZones.spawnSize.x / 2),
                Random.Range(randomSpawn.position.y - spawnZones.spawnSize.y / 2, randomSpawn.position.y + spawnZones.spawnSize.y / 2),
                Random.Range(randomSpawn.position.z - spawnZones.spawnSize.z / 2, randomSpawn.position.z + spawnZones.spawnSize.z / 2)
                );
        
        LastSpawn = NewSpawn;

    }
}

