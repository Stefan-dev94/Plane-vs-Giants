using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    [SerializeField] private GameObject _camera;
    [SerializeField] private float _parralaxEffect;
    private float _lenght, _startPos;
   

    private void Start()
    {
        _startPos = transform.position.x;
        _lenght = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    private void Update()
    {
        float dist = (_camera.transform.position.x * _parralaxEffect);
        transform.position= new Vector3(_startPos + dist,transform.position.y,transform.position.z);
    }
}
