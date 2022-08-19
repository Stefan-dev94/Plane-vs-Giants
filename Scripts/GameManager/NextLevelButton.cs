using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelButton : MonoBehaviour
{
    public void NextLevel()
    {
        SceneManager.LoadScene(1);
        LevelController.instance.IsEndGame();
    }
}
