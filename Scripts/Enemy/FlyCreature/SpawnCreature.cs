using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCreature : MonoBehaviour
{
    [SerializeField] private GameObject _creatureTemplate;
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private float _timeInstantiateCreature= 20f;
    [SerializeField] private float _repeatInstantiateCreature = 15;
    private int _randomSpawnPoints;
    public static bool spawnAllowed;

    private void Start()
    {
        spawnAllowed = true;
        InvokeRepeating("SpawnFlyCreature", _timeInstantiateCreature, _repeatInstantiateCreature);      
    }

    public void SpawnFlyCreature()
    {
        if (spawnAllowed)
        {
            _randomSpawnPoints = Random.Range(0, _spawnPoints.Length);
            Instantiate(_creatureTemplate, _spawnPoints[_randomSpawnPoints].position, Quaternion.identity);
           
        }
    }
}
