using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BirdMovement : MonoBehaviour
{
    public event Action gOverEvent;
    [SerializeField] float playerJumpSpeed = 5;
    public bool IsDead = false;
    public BlackScene bScene;

    private Vector3 _direction;


    private float gravity = -9.8f;
    
    void Start()
    {

    }

    void Update()
    {
        if(IsDead == true)
        {
            Time.timeScale = 0f;
            gOverEvent?.Invoke();
        }

        _direction.y += gravity * Time.deltaTime;
        transform.position += _direction * Time.deltaTime;
        Jump();
    }
    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _direction = Vector2.up * playerJumpSpeed;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        IsDead = true;
        bScene.FadeInStart();
    }
}
