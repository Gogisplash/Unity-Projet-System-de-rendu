using System.Collections;
using System.Collections.Generic;
using Engine.Utils;
using UnityEngine;


public class SpawnBarrel : MonoBehaviour
{
    [SerializeField]
    private GameObject spawning;

    [SerializeField]
    private List<Transform> spawnPoints;

    SpawnZone spawnZones;

    Transform LastSpawnZone;
    Transform NewSpawnZone;
    int barrelAmount = 0;
    public float spawnSpeed;
    float LastSpawn = 0;
    // Start is called before the first frame update
    protected void Start()
    {

        Spawn();
    }
    private void Update()
    {
        LastSpawn += Time.deltaTime;
        
        if (LastSpawn > spawnSpeed && barrelAmount < 100)
        {
            Spawn();
        }
    }
    public void Spawn()
    {
        barrelAmount++;
        LastSpawn = 0;
        NewSpawnZone = spawnPoints[Random.Range(0, spawnPoints.Count)];
        if(LastSpawnZone != null)
        {
            spawnPoints.Add(LastSpawnZone);

        }
        
        Transform randomSpawn = NewSpawnZone;
        spawnPoints.Remove(NewSpawnZone);

        GameObject instantied = Instantiate(spawning);
        spawnZones = GetComponentInChildren<SpawnZone>();
        instantied.transform.position = new Vector3(
                Random.Range(randomSpawn.position.x - spawnZones.spawnSize.x / 2, randomSpawn.position.x + spawnZones.spawnSize.x / 2),
                Random.Range(randomSpawn.position.y - spawnZones.spawnSize.y / 2, randomSpawn.position.y + spawnZones.spawnSize.y / 2),
                Random.Range(randomSpawn.position.z - spawnZones.spawnSize.z / 2, randomSpawn.position.z + spawnZones.spawnSize.z / 2)
                );
        
        LastSpawnZone = NewSpawnZone;

    }
}

