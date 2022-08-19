using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFish : MonoBehaviour
{
    [SerializeField] private GameObject _fishTemplate;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Instantiate(_fishTemplate, transform.position, transform.rotation);
        }
    }
}
