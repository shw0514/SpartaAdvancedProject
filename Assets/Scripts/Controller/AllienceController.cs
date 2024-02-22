using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllienceController : CharacterController
{
    GameManager gameManager;
    protected Transform ClosestTarget { get; private set; }

    protected virtual void Start()
    {
        gameManager = GameManager.instance;
        ClosestTarget = gameManager.Enemy;
    }

    protected virtual void FixedUpdate()
    {
        
    }

    protected float DistanceToTarget()
    {
        return Vector3.Distance(transform.position, ClosestTarget.position);
    }

    protected Vector2 DirectionToTarget()
    {
        return (ClosestTarget.position - transform.position).normalized;
    }
}
