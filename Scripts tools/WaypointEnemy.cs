using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class WaypointEnemy : MonoBehaviour
{
    [SerializeField]
    private float minMovementSpeed = 1.0f;
    [SerializeField]
    private float maxMovementSpeed = 5.0f;
    [SerializeField]
    private float maxPauseTime = 1.0f;
    [SerializeField]
    private Transform waypointA;
    [SerializeField]
    private Transform waypointB;
    [SerializeField]
    private Animator myAnimator;

    private float currentMovementSpeed;
    private bool movingForward = false;
    private float _timer = 0.0f;
    private bool pauseMovement = false;

    void Start()
    {
        myAnimator.Play("Custom Enemy Animation", 0, Random.Range(0.0f, 10.0f));
        currentMovementSpeed = Random.Range(minMovementSpeed, maxMovementSpeed);
        movingForward = (Random.Range(0, 2) == 0);
        _timer = Random.Range(0.0f, maxPauseTime);
    }

    private void Update()
    {
        if (_timer <= 0)
        {
            _timer = Random.Range(0.0f, maxPauseTime);
            movingForward = (Random.Range(0, 2) == 0);
            currentMovementSpeed = Random.Range(minMovementSpeed, maxMovementSpeed);
            if (pauseMovement)
            {
                pauseMovement = false;
            }
            else
            {
                pauseMovement = (Random.Range(0, 2) == 0);
            }
        }
        _timer -= Time.deltaTime;

        if (pauseMovement && currentMovementSpeed > 0)
        {
            currentMovementSpeed -= Time.deltaTime;
        }
        else if (pauseMovement)
        {
            return;
        }

        Transform target;
        if (movingForward)
        {
            target = waypointB;
        }
        else
        {
            target = waypointA;
        }
        transform.position = Vector2.MoveTowards(transform.position, target.position, currentMovementSpeed * Time.deltaTime);
        if (Vector2.Distance(transform.position, target.position) < 0.01f)
        {
            pauseMovement = (Random.Range(0, 2) == 0);
        }
    }
}
