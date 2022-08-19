using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateObstacles : MonoBehaviour
{
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private GameObject _bulletTemplate;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Instantiate(_bulletTemplate, _spawnPoint.position, Quaternion.identity);
         
        }
    }
}
