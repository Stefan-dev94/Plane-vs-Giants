using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemEnable : MonoBehaviour
{
    [SerializeField] private GameObject _enemyEnable;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            _enemyEnable.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            _enemyEnable.SetActive(false);
        }
    }
}
