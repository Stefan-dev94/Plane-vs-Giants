using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDown : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;
    private Rigidbody2D _rb;
    [SerializeField] private GameObject _explosion;
    private float _damage = 1f;
    

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        _rb.velocity = -transform.up * _speed;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent<PlaneHealth>(out PlaneHealth planeHealth))
        {
            planeHealth.TakeDamage(_damage);
            Instantiate(_explosion, transform.position, transform.rotation);
            Destroy(gameObject);
        }
            if (collision.gameObject.tag == "Ground")
            
        {
            Instantiate(_explosion, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
