using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private Transform _shotPoint;
    [SerializeField] private Bullet _bulletTemplate;
    [SerializeField] private float _delayBetwenShoots;

    private float _timeAfterShoots;

    private void Update()
    {
        Shoot();
    }
    public void Shoot()
    {
        _timeAfterShoots += Time.deltaTime;
        if (SimpleInput.GetKey(KeyCode.Space))
        {
            if (_timeAfterShoots > _delayBetwenShoots)
            {
                Instantiate(_bulletTemplate, _shotPoint.transform.position, transform.rotation);

                _timeAfterShoots = 0;
            }
        }
    }
}
