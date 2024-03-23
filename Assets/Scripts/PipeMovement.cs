using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    [SerializeField] float pipeSpeed = 1;
    BackgroundMovement bGround;
    void Start()
    {
        bGround = FindObjectOfType<BackgroundMovement>().GetComponent<BackgroundMovement>();
    }

    void Update()
    {
        PipeMove();
    }
    void PipeMove()
    {
        if(bGround.hardmode == true)
        {
            pipeSpeed = 10;
        }
        transform.position += Vector3.left * pipeSpeed * Time.deltaTime;
        if(transform.position.x <= -13)
        {
            Destroy(gameObject);
        }
    }
}
