using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss1Health : MonoBehaviour
{
    [SerializeField] private Transform[] _explodePosition;
    [SerializeField] private GameObject _explode;
    [SerializeField] private GameObject _buf;
    [SerializeField] private AudioSource _monsterDie;
    [SerializeField] private float _desrtoyEnemyTime = 1.5f;
    [SerializeField] private GameObject _spawnPointsEnable;
    public float HitPoints;
    public float MaxHitPoints = 10;
    private Animator _anim;
    private int _randomSpawnPoints;
    public EnemyBarHealth healthBar;



    private void Start()
    {
        HitPoints = MaxHitPoints;
        _anim = GetComponent<Animator>();
        healthBar.SetMaxHealth(MaxHitPoints);
    }

    public void TakeDamage(float damage)
    {
        HitPoints -= damage;
        healthBar.SetHealth(HitPoints);

        if (HitPoints <= 0)
        {
            _anim.SetBool("isDie", true);
            InvokeRepeating("ExplodeEnemy", 0f, 0.7f);
            Destroy(gameObject, _desrtoyEnemyTime);
            _buf.SetActive(false);
            _monsterDie.Play();
            Destroy(_spawnPointsEnable);
        }

    }
    private void ExplodeEnemy()
    {
        _randomSpawnPoints = Random.Range(0, _explodePosition.Length);
        Instantiate(_explode, _explodePosition[_randomSpawnPoints].position, Quaternion.identity);
    }
}

