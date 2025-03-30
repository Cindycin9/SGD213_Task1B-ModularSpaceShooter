using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{

    // Variable for isGameOver and GameOverScreen
    public static bool isGameOver;
    public GameObject gameOverScreen;


    // isGameOver is set as inactive unless awakened
    private void Awake()
    {
        isGameOver = false;
    }

    void Start()
    {
        
    }

    // If the isGameOver is awakened, the Game Over Screen will activate
    void Update()
    {
        if(isGameOver)
        {
            gameOverScreen.SetActive(true);
        }
    }

    // Restarts the level when the Restart Button is pressed
    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Debug.Log("GameRestarted");
    }

    // Quits the game when the Quit Button is pressed
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("GameQuit");
    }
}
