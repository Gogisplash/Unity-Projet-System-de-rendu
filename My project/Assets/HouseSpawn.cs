using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Engine.Utils;


public class HouseSpawn : Singleton<SpawnObjectif>
{
    [SerializeField]
    private GameObject spawning;

    [SerializeField]
    private List<Transform> spawnPoints;

    SpawnZone spawnZones;

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
        if (LastSpawn != null)
        {
            spawnPoints.Add(LastSpawn);

        }

        Transform randomSpawn = NewSpawn;
        spawnPoints.Remove(NewSpawn);

        GameObject instantied = Instantiate(spawning);
        spawnZones = GetComponentInChildren<SpawnZone>();
        instantied.transform.position = new Vector3(
                Random.Range(randomSpawn.position.x - spawnZones.spawnSize.x / 2, randomSpawn.position.x + spawnZones.spawnSize.x / 2),
                Random.Range(randomSpawn.position.y - spawnZones.spawnSize.y / 2, randomSpawn.position.y + spawnZones.spawnSize.y / 2),
                Random.Range(randomSpawn.position.z - spawnZones.spawnSize.z / 2, randomSpawn.position.z + spawnZones.spawnSize.z / 2)
                );

        LastSpawn = NewSpawn;

    }
}
