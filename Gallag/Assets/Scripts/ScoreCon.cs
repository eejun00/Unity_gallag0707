using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCon : MonoBehaviour
{
    public GameObject overScore;
    private GameManager gameManager;
    private bool isFirecracker;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.FindAnyObjectByType<GameManager>();
        isFirecracker = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(gameManager.score % 1000 == 0 && gameManager.score != 0 && isFirecracker)
        {
            Instantiate(overScore, transform.position, transform.rotation);
            Destroy(overScore,1f);
            isFirecracker = false;
        }
        else if(gameManager.score % 1000 != 0)
        {
            isFirecracker = true;
        }
    }
}
