using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyExplosion : MonoBehaviour
{
    [SerializeField] private float _destroyExplode;
    private void Start()
    {
        Destroy(gameObject, _destroyExplode);
    }
}
