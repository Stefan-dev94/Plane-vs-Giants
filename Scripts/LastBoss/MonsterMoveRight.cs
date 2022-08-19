using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMoveRight : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Rigidbody2D _rb;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>(); 
    }

    void Update()
    {
        _rb.velocity = transform.right * _speed;
    
    }
}
