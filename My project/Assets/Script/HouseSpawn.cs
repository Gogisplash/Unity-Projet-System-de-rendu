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
       
        instantied.transform.position = new Vector3(randomSpawn.position.x, randomSpawn.position.y, randomSpawn.position.z);

        LastSpawn = NewSpawn;

    }
}
