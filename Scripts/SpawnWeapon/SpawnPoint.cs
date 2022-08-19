using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Transform _spawnPosition;
    [SerializeField] private GameObject[] _weapon;
    [SerializeField] private float _timeInstantiate = 2f;
    [SerializeField] private float _repeatRate = 20f;
    private int _randomWeapon;


    private void Start()
    { 
        InvokeRepeating("SpawnWeapon", _timeInstantiate,_repeatRate);
    } 


    private void SpawnWeapon()
    {    
        _randomWeapon = Random.Range(0, _weapon.Length);
        Instantiate(_weapon[_randomWeapon],_spawnPosition.position, Quaternion.identity);
    }

}
