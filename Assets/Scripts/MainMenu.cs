using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public string startLevel;

    public string levelSelect;

    public string level1Tag;

    public void NewGame()
    {
        PlayerPrefs.SetInt(level1Tag, 1);
        SceneManager.LoadScene(startLevel);
    }

    public void LevelSelect()
    {
        PlayerPrefs.SetInt(level1Tag, 1);
        SceneManager.LoadScene(levelSelect);
    }

    public void QuitGame()
    {
        QuitGame();
    }
}
