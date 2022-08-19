using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBulletSpawn : MonoBehaviour
{
    [SerializeField] private Transform _spawnPosition;
    [SerializeField] private GameObject _bullet;
    [SerializeField] private float _timeInstantiate = 2f;
    [SerializeField] private float _repeatRate = 20f;

    private void Start()
    {
        InvokeRepeating("SpawnWeapon", _timeInstantiate, _repeatRate);
    }


    private void SpawnWeapon()
    {
        Instantiate(_bullet, _spawnPosition.position, Quaternion.identity);
    }
}
