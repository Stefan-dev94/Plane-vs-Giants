using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanicSound : MonoBehaviour
{

    [SerializeField] private AudioSource _panic;
    [SerializeField] private GameObject _effectExplode;
    [SerializeField] private Transform _positionExplode;
     public int _timeDestroy=1;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            _panic.Play();
            Instantiate(_effectExplode, _positionExplode.position, Quaternion.identity);
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
        }
    }
}
