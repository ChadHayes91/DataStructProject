using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour {

    public string selectLevel;

    public string mainMenu;

    public bool isPaused;

    public GameObject pauseMenuCanvas;

	
	// Update is called once per frame
	void Update () {
        if (isPaused)
        {
            pauseMenuCanvas.SetActive(true);
            Time.timeScale = 0f;
        }		
        else
        {
            pauseMenuCanvas.SetActive(false);
            Time.timeScale = 1f;
        }

        if (Input.GetKeyDown("escape"))
        {
            isPaused = !isPaused;
        }

	}

    public void Resume()
    {
        isPaused = false;
    }

    public void levelSelect()
    {
        SceneManager.LoadScene(selectLevel);
    }

    public void quit()
    {
        SceneManager.LoadScene(mainMenu);
    }
        
}
