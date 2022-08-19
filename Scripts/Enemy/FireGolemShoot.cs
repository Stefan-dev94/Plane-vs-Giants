using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireGolemShoot : MonoBehaviour
{
    private float _timeBtwShoots;
    [SerializeField] private float _startBtwShoots;
    [SerializeField] private GameObject _projectile;
   


    private void Start()
    {
        _timeBtwShoots = _startBtwShoots;
    }

    private void Update()
    {
       
        if(_timeBtwShoots <= 0)
        {
            Instantiate(_projectile,transform.position, Quaternion.identity);
            _timeBtwShoots = _startBtwShoots;
        }
        else
        {
            _timeBtwShoots -= Time.deltaTime;
        }
    }
}
