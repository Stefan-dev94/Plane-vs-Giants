using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMissileWeapon : MonoBehaviour
{
    [SerializeField] private Transform _missilePoint;
    [SerializeField] private GameObject _missileTemplate;
    [SerializeField] private float _delayBetwenShoots;

    private float _timeAfterShoots;

    private void Update()
    {
        Shoot();
    }
    public void Shoot()
    {
        _timeAfterShoots += Time.deltaTime;
        if (SimpleInput.GetKey(KeyCode.A) && AutoMissileText.AutoMissileCount > 0)
        {
            if (_timeAfterShoots > _delayBetwenShoots)
            {
                Instantiate(_missileTemplate, _missilePoint.transform.position, transform.rotation);
                AutoMissileText.AutoMissileCount -= 1;
                _timeAfterShoots = 0;
            }
        }
    }
}
