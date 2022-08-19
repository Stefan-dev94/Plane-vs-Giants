using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private GameObject _explode;
    [SerializeField] private AudioSource _soundProjectile;
  
   
    private Transform _player;
    private Vector2 _target;

    private void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player").transform;

        _target = new Vector2(_player.position.x, _player.position.y);

        _soundProjectile.Play();

    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, _target, _speed * Time.deltaTime);

       if(transform.position.x == _target.x && transform.position.y == _target.y)
        {
            Instantiate(_explode, transform.position, Quaternion.identity);
            DestroyProjectile();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent<PlaneHealth>(out PlaneHealth planeHealth))
        {
            planeHealth.TakeDamage(0.5f);
            Instantiate(_explode, transform.position, Quaternion.identity);
            DestroyProjectile();
        }
    }
    private void DestroyProjectile()
    {
        Destroy(gameObject);       
    }
}
