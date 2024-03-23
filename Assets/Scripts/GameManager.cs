using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System;

public class GameManager : MonoBehaviour
{
    public static bool gameStarted = false;
    public GameObject startPanel;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI finalScore;
    public float survivingTime = 0;
    BirdMovement bMovement;

    void Start()
    {
        Time.timeScale = 0f;
        bMovement = FindObjectOfType<BirdMovement>().GetComponent<BirdMovement>();
        bMovement.gOverEvent += ScoreSetting;
    }


    void Update()
    {
        if (gameStarted == true)
        {
            ScoreUp();
        }
    }
    public void WhenStart()
    {
        gameStarted = true;
        Time.timeScale = 1f;
        startPanel.SetActive(false);
    }
    public void Restart()
    {
        Debug.Log("sda");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ScoreUp()
    {
        survivingTime += Time.deltaTime;
        scoreText.text = $"{(int)survivingTime}";
    }
    private void ScoreSetting()
    {
        finalScore.text = $"{(int)survivingTime}";
        scoreText.gameObject.SetActive(false);
    }
    private void OnDisable()
    {
        bMovement.gOverEvent -= ScoreSetting;
    }
}
