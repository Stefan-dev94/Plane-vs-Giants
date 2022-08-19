using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatureHealth : MonoBehaviour
{
    [SerializeField] private AudioSource _monsterDie;
    [SerializeField] private float _desrtoyEnemyTime = 1f;
    public float HitPoints;
    public float MaxHitPoints = 0.2f;
    private Animator _anim;
    private Rigidbody2D _rb;
    

    private void Start()
    {
        HitPoints = MaxHitPoints;
        _anim = GetComponent<Animator>();
        _rb = GetComponent<Rigidbody2D>();
    }

    public void TakeDamage(float damage)
    {
        HitPoints -= damage;

        if (HitPoints <= 0)
        {
            _anim.SetBool("isDie", true);
            _rb.gravityScale = 30f;
            Destroy(gameObject, _desrtoyEnemyTime);
            _monsterDie.Play();
        }
    }
}
