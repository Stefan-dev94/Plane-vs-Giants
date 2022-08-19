using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatureControll : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Rigidbody2D _rb;
    private GameObject _target;
    private Vector3 _directionToTarget;
    private Vector3 _localScale;

    private void Start()
    {
        _target = GameObject.FindGameObjectWithTag("Player");
        _rb = GetComponent<Rigidbody2D>();
        _localScale = transform.localScale;
    }

    private void FixedUpdate()
    {
        MoveCreature(); 
    }

    private void MoveCreature()
    {
        _directionToTarget = (_target.transform.position - transform.position).normalized;
        _rb.velocity = new Vector2(_directionToTarget.x, _directionToTarget.y) * _speed;
    }

    private void LateUpdate()
    {
        if (_rb.velocity.x > 0)
        {
            transform.localScale = new Vector3(_localScale.x, _localScale.y, _localScale.z);
        } 
        else if (_rb.velocity.x < 0)
        {
            transform.localScale = new Vector3(-_localScale.x, _localScale.y, _localScale.z);
        }
    }

}
