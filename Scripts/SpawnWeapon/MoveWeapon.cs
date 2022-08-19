using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWeapon : MonoBehaviour
{
    [SerializeField] private float _speed=5f;
    [SerializeField] private float _frequency=20f;
    [SerializeField] private float _magnitude=0.5f;
    Vector3 pos, localScale;


    private void Start()
    {
        pos = transform.position;
        localScale = transform.localScale;
    }

    private void Update()
    {
        pos -= transform.right * Time.deltaTime * _speed;
        transform.position = pos + transform.up * Mathf.Sin(Time.time * _frequency) * _magnitude;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Finish")
        {
            Destroy(gameObject);
        }
    }
}
