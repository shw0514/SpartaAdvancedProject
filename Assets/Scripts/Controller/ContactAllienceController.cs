using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ContactAllienceController : AllienceController
{
    private float createTime = 0.0f;
    private float moveTime = 0.1f;
    private bool isCanMove = false;
    private GameObject target;
    private bool _isCollidingWithTarget;

    [SerializeField] private SpriteRenderer characterRenderer;

    protected override void Start()
    {
        base.Start();
        target = GameObject.FindGameObjectWithTag("Enemy");
    }

    protected override void FixedUpdate()
    {
        base.FixedUpdate();

        createTime += Time.deltaTime;
        Vector2 direction = Vector2.zero;
        Rotate(direction);
        if (createTime >= moveTime)
            isCanMove = true;
        if (isCanMove)
        {
            transform.position = Vector2.MoveTowards(gameObject.transform.position, target.transform.position, 0.03f);
        } 
    }

    private void Rotate(Vector2 direction)
    {
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(rotZ, Vector3.forward);
    }
}
