using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FighterRespawnScript : MonoBehaviour
{
    public GameObject fighterPrefab;
    public float spawnRateMin = 0.5f;
    public float spawnRateMax = 3f;

    //private Transform target;
    private float spawnRate;
    private float timeAfterSpawn;

    void Start()
    {
        timeAfterSpawn = 0f;
        spawnRate = Random.Range(spawnRateMin, spawnRateMax);
        //target = FindObjectOfType<PlayerController>().transform;

    }

    // Update is called once per frame
    void Update()
    {
        timeAfterSpawn += Time.deltaTime;

        if(timeAfterSpawn >= spawnRate)
        {
            timeAfterSpawn = 0f;

            GameObject fighter = Instantiate(fighterPrefab, new Vector3(Random.Range(-10,10),1.2f,Random.Range(80,90)), transform.rotation);

            //bullet.transform.forward;

            spawnRate = Random.Range(spawnRateMin, spawnRateMax);
        }
    }
}
