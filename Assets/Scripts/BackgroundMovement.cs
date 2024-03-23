using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMovement : MonoBehaviour
{
    [SerializeField] float backgroundSpeed = 5f;
    float scrollRange = 12.6f;
    SpriteRenderer mySpriteRender;
    GameManager gManager;
    public bool hardmode = false;
    void Start()
    {
        mySpriteRender = transform.GetComponent<SpriteRenderer>();
        gManager = FindObjectOfType<GameManager>().GetComponent<GameManager>();
    }

    void Update()
    {
        BackgroundMove();
        Hardmode();
    }
    void BackgroundMove()
    {
        transform.position += Vector3.left * backgroundSpeed * Time.deltaTime;
        if (transform.position.x <= -scrollRange)
        {
            transform.position = new Vector3(scrollRange, 0f, 0f);
        }
    }
    void Hardmode()
    {
        if(gManager.survivingTime >= 30)
        {
            mySpriteRender.color = Color.red;
            hardmode = true;
        }
    }
}
