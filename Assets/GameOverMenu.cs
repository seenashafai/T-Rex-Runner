using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverMenu : MonoBehaviour {

    public static bool GamePaused = false;

    public GameObject pauseMenuUI;
    public GameObject gameOverMenuUI;

	// Update is called once per frame
	void Update () 
    {
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            print("Esc pressed");
            if (GamePaused)
            {
                print("Resume");
                Resume();
            }

            else
            {
                print("Pause");
                Pause();
            }
        }

        if (CollisionDetection.gameOver == true)
        {
            print("Game over detected");
            gameOverMenu();        
        }


		
	}

    void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GamePaused = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GamePaused = true;
    }

    void gameOverMenu()
    {
        gameOverMenuUI.SetActive(true);
        Time.timeScale = 0f;
    }
 
}
