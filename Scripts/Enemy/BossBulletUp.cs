using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BossBulletUp : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;
    private Rigidbody2D _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        _rb.velocity = transform.up * _speed ;
        Destroy(gameObject, 2f);
    }
}
