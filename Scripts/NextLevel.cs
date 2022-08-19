using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevel : MonoBehaviour
{
    [SerializeField] private GameObject _winPanel;
    [SerializeField] private GameObject _audioMute;
    [SerializeField] private GameObject _plane;
    private void OnTriggerEnter2D(Collider2D collision)
    {
       if(collision.gameObject.tag == "Player")
        {
            _winPanel.SetActive(true);
            _audioMute.SetActive(false);
            _plane.SetActive(false);
        }
    }
}
