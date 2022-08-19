using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombWeapon : MonoBehaviour
{
    [SerializeField] private Transform _bombPoint;
    [SerializeField] private GameObject _bombTemplate;
    [SerializeField] private float _delayBetwenShoots;

    private float _timeAfterShoots;

    private void Update()
    {
        Shoot();
    }
    public void Shoot()
    {
        _timeAfterShoots += Time.deltaTime;
        if (SimpleInput.GetKey(KeyCode.B) && BombText.BombCount > 0)
        {
            if (_timeAfterShoots > _delayBetwenShoots)
            {
                Instantiate(_bombTemplate, _bombPoint.transform.position, transform.rotation);
                BombText.BombCount -= 1;
                _timeAfterShoots = 0;
            }
        }
    }
}
