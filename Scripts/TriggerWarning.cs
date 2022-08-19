using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerWarning : MonoBehaviour
{
    [SerializeField] private Transform _position;
    [SerializeField] private GameObject _warningSign;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Meteor")
        {
            Instantiate(_warningSign, _position.position, transform.rotation);
        }
    }
}
