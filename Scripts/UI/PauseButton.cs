using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseButton : MonoBehaviour
{
    [SerializeField] private GameObject _pauseMenu;
    
    public void Pause()
    {
        _pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        AudioListener.volume = 0.1f;
    }

    public void Resume()
    {
        _pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        AudioListener.volume = 1f;

    }
    public void Menu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
        AudioListener.volume = 1f;
    }
}
