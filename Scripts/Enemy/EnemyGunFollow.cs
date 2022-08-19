using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGunFollow : MonoBehaviour
{
    [SerializeField] private GameObject _player;

    private void Update()
    {
        GunFollow();
    }

    private void GunFollow()
    {
        Vector3 playerPos = _player.transform.position;

        Vector2 direction = new Vector2(playerPos.x - transform.position.x, playerPos.y - transform.position.y);
        transform.up = direction;
    }
}
