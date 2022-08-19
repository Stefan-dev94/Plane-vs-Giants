using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneHealth : MonoBehaviour
{
    [SerializeField]private GameObject _explosion;
    [SerializeField] private GameObject _particleSystem;
    [SerializeField] private GameObject _spawnPointenable;
    private AudioSource _engineDefect;
    public GameObject _plane;
    public GameObject Panel;

    public float health = 1;

    private void Start()
    {
        Panel.SetActive(false);
        _engineDefect = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "City")
        {
            health--;

            if (health <= 0)
            {
                Instantiate(_explosion, transform.position, Quaternion.identity);
                _plane.SetActive(false);
                Panel.SetActive(true);
                Destroy(_spawnPointenable);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        health--;

        if (health <= 0)
        {
            Instantiate(_explosion, transform.position, Quaternion.identity);
            _plane.SetActive(false);
            Panel.SetActive(true);
            Destroy(_spawnPointenable);
        }
    }
    public void TakeDamage(float damage)
    {
         health -= damage;
        if(health == 0.5f)
        {
            _particleSystem.SetActive(true);
            _engineDefect.pitch = 2f;
        }
        if (health <= 0)
        {
            Instantiate(_explosion, transform.position, Quaternion.identity);
            _plane.SetActive(false);
            Panel.SetActive(true);
            Destroy(_spawnPointenable);
        }
    }
}
