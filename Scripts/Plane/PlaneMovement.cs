using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneMovement : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _acceleration;
    [SerializeField] private float _rotationControll;
    [SerializeField] private AudioSource _soundEffect;
     
    float MoveY, MoveX =1;
    
    private Rigidbody2D _rb;
 

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
       MoveY = SimpleInput.GetAxis("Vertical");   
    }
    private void FixedUpdate()
    {
        Vector2 Vel = transform.right * (MoveX * _acceleration);
        _rb.AddForce(Vel);

        float Dir = Vector2.Dot(_rb.velocity, _rb.GetRelativeVector(Vector2.right));

        if(_acceleration > 0)
        {
            if(Dir > 0)
            {
                _rb.rotation += MoveY * _rotationControll * (_rb.velocity.magnitude / _speed);
            }
            else
            {
                _rb.rotation -= MoveY * _rotationControll * (_rb.velocity.magnitude / _speed);  
            }
        }

        float thrustForce = Vector2.Dot(_rb.velocity, _rb.GetRelativeVector(Vector2.down)) * 2.0f;
       
        Vector2 relForce = Vector2.up * thrustForce;

        _rb.AddForce(_rb.GetRelativeVector(relForce));

        if(_rb.velocity.magnitude > _speed)
        {
            _rb.velocity = _rb.velocity.normalized * _speed;
        }
    }
}
