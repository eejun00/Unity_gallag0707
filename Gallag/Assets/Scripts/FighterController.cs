using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FighterController : MonoBehaviour
{
    private GameManager gameManager;
    public GameObject fighterBulletPrefab;
    public GameObject fighterDeathPrefab;
    public float spawnRateMin = 0.5f;
    public float spawnRateMax = 3f;

    private float spawnRate;
    private float timeAfterSpawn;

    public float speed = 8f;
    private Rigidbody fighterRigidbody;
    void Start()
    {
        gameManager = GameObject.FindAnyObjectByType<GameManager>();
        fighterRigidbody = GetComponent<Rigidbody>();
        fighterRigidbody.velocity = transform.forward * speed;

        timeAfterSpawn = 0f;
        spawnRate = Random.Range(spawnRateMin, spawnRateMax);

        // 플레이어가 적 전투기의 총알과 만났을 때 ????
        Destroy(gameObject, 5f);
    }


    void Update()
    {
        timeAfterSpawn += Time.deltaTime;

        if (timeAfterSpawn >= spawnRate)
        {
            timeAfterSpawn = 0f;

            GameObject fighterBullet = Instantiate(fighterBulletPrefab, transform.position, transform.rotation);

            //bullet.transform.forward;

            spawnRate = Random.Range(spawnRateMin, spawnRateMax);
        }
    }

    public void Die()
    {
        gameObject.SetActive(false);
        GameObject death = Instantiate(fighterDeathPrefab, transform.position, transform.rotation);
        Destroy(death, 2f);

        gameManager.score += 200;

        //이 자리에 gamescore추가 삽입
    }
    
}
