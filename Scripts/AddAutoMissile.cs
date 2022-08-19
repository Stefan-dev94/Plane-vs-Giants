using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddAutoMissile : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            AutoMissileText.AutoMissileCount += 1;
            Destroy(gameObject);
        }
    }
}
