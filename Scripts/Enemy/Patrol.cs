using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    [SerializeField ]private float _speed;
    [SerializeField] private float _distance;
    [SerializeField] private Transform _groundDetected;

    private bool movingRight = true;  

    private void Update()
    {
        transform.Translate(Vector3.left * _speed * Time.deltaTime);
        RaycastHit2D groundInfo = Physics2D.Raycast(_groundDetected.position, Vector2.down, _distance);
  
        if(groundInfo.collider == false)
        {
            if(movingRight == true)
            {
                transform.eulerAngles = new Vector3(0, 180, 0);
                movingRight = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                movingRight = true;
            }
        }
    }  
}
