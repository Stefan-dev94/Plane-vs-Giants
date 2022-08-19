using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishAddForce : MonoBehaviour
{
    private Rigidbody2D _rb;
    [SerializeField] private float _force=1f;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();

        _rb.AddForce(Vector2.up * _force, ForceMode2D.Impulse);
    }
}
