using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyCounter : MonoBehaviour
{
    [SerializeField] private Text _enemyCountText;
    [SerializeField] private GameObject _winPanel;
    [SerializeField] private GameObject _audioMute;
    [SerializeField] private GameObject _plane;
    private GameObject[] _enemies;


    private void Update()
    {
        _enemies = GameObject.FindGameObjectsWithTag("Enemy");

        _enemyCountText.text = "   " + _enemies.Length.ToString(); 

        if(_enemies.Length == 0)
        {
            _winPanel.SetActive(true);
           // Time.timeScale = 0;
            _audioMute.SetActive(false);
            _plane.SetActive(false);
        }
    }
}
