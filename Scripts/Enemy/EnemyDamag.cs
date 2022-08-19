using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamag : MonoBehaviour
{
    [SerializeField] private float _damage;
    private void OnTriggerStay2D(Collider2D collision)
    {
        CityHealthBar.Health -= _damage * Time.deltaTime;
    }
}
