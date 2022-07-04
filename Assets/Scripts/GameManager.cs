using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    GameObject PauseMenu;

    public static bool gamePaused;
    private void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            gamePaused = !gamePaused;
            PauseGame();
        }
    }
    public void PauseGame()
    {
        if (gamePaused)
        {
            PauseMenu.SetActive(true);
            Time.timeScale = 0f;
        }
        else
        {
            PauseMenu.SetActive(false);
            Time.timeScale = 1;
        }
    }

    public void QuitToMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Main Menu");
    }

    public void ContinueGame()
    {
        if(gamePaused)
        {
            Time.timeScale = 1;
            PauseMenu.SetActive(false);
            gamePaused = !gamePaused;
        }
    }
}
