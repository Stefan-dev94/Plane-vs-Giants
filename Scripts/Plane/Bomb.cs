using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    [SerializeField] private GameObject _explode;
    [SerializeField] private float _damage;

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
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Enemy")
        {
            Instantiate(_explode, transform.transform.position, Quaternion.identity);
        }
    }
}
