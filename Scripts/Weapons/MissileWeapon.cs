using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileWeapon : MonoBehaviour
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
        if (SimpleInput.GetKey(KeyCode.M) && MissileText.MissileCount>0)
        {
            if (_timeAfterShoots > _delayBetwenShoots)
            {
                Instantiate(_missileTemplate, _missilePoint.transform.position, transform.rotation);
                MissileText.MissileCount -= 1;
                _timeAfterShoots = 0;
            }
        }
    }
}
