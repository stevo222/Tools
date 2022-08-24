using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float movementSpeed = 1.0f;
    [SerializeField]
    private Transform waypointA;
    [SerializeField]
    private Transform waypointB;
    
    private bool movingForward = true;
    private Transform currentTarget;

    private void FixedUpdate()
    {
        if (movingForward)
        {
            currentTarget = waypointB;
        }
        else
        {
            currentTarget = waypointA;
        }
        transform.position = Vector2.MoveTowards(transform.position, 
                                                        currentTarget.position, 
                                                        movementSpeed * Time.deltaTime);
        if (Vector2.Distance(transform.position, currentTarget.position) < 0.01f)
        {
            movingForward = !movingForward;
        }
    }
    
}




