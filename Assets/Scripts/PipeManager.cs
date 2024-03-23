using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeManager : MonoBehaviour
{
    float spawnTime = 1f;
    public GameObject myPipes;
    BackgroundMovement bGround;
    float maxY = 3f;
    float minY = -1f;
    float minTime = 1f;
    float maxTime = 1.5f;
    float currentTime = 0f;
    void Start()
    {
        bGround = FindObjectOfType<BackgroundMovement>().GetComponent<BackgroundMovement>();
    }

    void Update()
    {
        if (GameManager.gameStarted)
        {
            currentTime += Time.deltaTime;
            if (bGround.hardmode == true)
            {
                minTime = 0.5f;
                maxTime = 1f;
            }
            if (currentTime >= spawnTime)
            {
                MakePipes();
                currentTime = 0f;
                spawnTime = Random.Range(minTime, maxTime);
            }
        }
    }
    void MakePipes()
    {
        Instantiate(myPipes, new Vector3(11f, Random.Range(minY, maxY), 0f), Quaternion.identity);
    }
}
