using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddMissile : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            MissileText.MissileCount += 1;
            Destroy(gameObject);
        }
    }
}
