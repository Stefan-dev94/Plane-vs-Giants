using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    [SerializeField] private float _damage = 0.5f;
    [SerializeField] private AudioSource _creatureAttack;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent<PlaneHealth>(out PlaneHealth planeHealth))
        {
            planeHealth.TakeDamage(_damage);
            _creatureAttack.Play();
        }
    }
}
