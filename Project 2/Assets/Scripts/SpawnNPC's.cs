using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNPC : MonoBehaviour
{
    // Index for prefabs
    public GameObject[] npc;
    private int npcIndex;

    public float startDelay;
    public float repeatRate;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomNpc", startDelay, repeatRate);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void SpawnRandomNpc() // spawns NPC's
    {
        int npcIndex = Random.Range(0, npc.Length);

        Vector3 spawnPos = new Vector3(-20, -3.78f, Random.Range(-17, -22));

        Vector3 rotationSpawn = new Vector3(npc[npcIndex].transform.rotation.x, 90, npc[npcIndex].transform.rotation.z);
        Instantiate(npc[npcIndex], spawnPos, Quaternion.Euler(rotationSpawn.x, rotationSpawn.y, rotationSpawn.z));
    }
}
