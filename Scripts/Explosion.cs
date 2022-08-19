using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Explosion : MonoBehaviour
{
    [SerializeField] private GameObject _explosion;
 
    private void OnTriggerEnter2D(Collider2D collision)
    {
            Instantiate(_explosion, transform.transform.position, Quaternion.identity);
            Destroy(gameObject);
           // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
