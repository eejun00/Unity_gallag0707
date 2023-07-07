using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public GameObject gameOverUi = default;
    public Text lifeText = default;
    public Text scoreText = default;

    public float score = default;
    public int life = 3;
    private bool isGameOver = default;

    // Start is called before the first frame update
    void Start()
    {
        score = 0f;
        isGameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver == false)
        {
            lifeText.text = string.Format("Life : ");
            scoreText.text = string.Format("Score : {0}", (int)score);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("PlayScene");
        }
    }

    public void EndGame()
    {
        isGameOver = true;
        gameOverUi.SetActive(true);

        float bestScore = PlayerPrefs.GetFloat("BestScore");

        if (score > bestScore)
        {
            bestScore = score;
            PlayerPrefs.SetFloat("BestScore", bestScore);
        }

        scoreText.text = string.Format("Best Score : {0}", (int)bestScore);
    }
}
