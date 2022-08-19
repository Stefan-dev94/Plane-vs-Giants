using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileAutoFollow : MonoBehaviour
{
    private GameObject[] _target;
    //[SerializeField] private float _speed;
    [SerializeField] private GameObject _explode;
    [SerializeField] private float _damage;
    [SerializeField] private float _rotationSpeed = 1f;

    Quaternion _rotateToTarget;
    Vector3 _dir;
    private int _randomGolem;

    private Rigidbody2D _rb;

    private void Start()
    {
        _target = GameObject.FindGameObjectsWithTag("Enemy");
        _rb = GetComponent<Rigidbody2D>();
        _randomGolem = Random.Range(0, _target.Length);
    }


    private void Update()
    {
       
        _dir = (_target[_randomGolem].transform.position - transform.position).normalized;
        float angle = Mathf.Atan2(_dir.y, _dir.x) * Mathf.Rad2Deg;
        _rotateToTarget = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, _rotateToTarget, Time.deltaTime * _rotationSpeed);
        _rb.velocity = new Vector2(_dir.x * 12, _dir.y *12);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var enemy = collision.collider.GetComponent<EnemyHealth>();
        var boss = collision.collider.GetComponent<Boss1Health>();
        if (enemy)
        {
            enemy.TakeDamage(_damage);
            Instantiate(_explode, transform.transform.position, Quaternion.identity);
        }
        if (boss)
        {
            boss.TakeDamage(_damage);
            Instantiate(_explode, transform.transform.position, Quaternion.identity);
        }
        Destroy(gameObject);
    }
}
