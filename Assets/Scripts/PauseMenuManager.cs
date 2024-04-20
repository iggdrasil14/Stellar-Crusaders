using UnityEngine;

public class PauseMenuManager : MonoBehaviour
{
    public GameObject pauseMenuUI;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //Debug.Log("Escape pressed. Menu active: " + pauseMenuUI.activeInHierarchy);
            if (pauseMenuUI.activeInHierarchy)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    public void ResumeGame()
    {
        Debug.Log("Resuming game.");
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
    }

    public void PauseGame()
    {
        Debug.Log("Pausing game.");
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
    }

    public void QuitGame()
    {
        Debug.Log("Quitting game.");
        Application.Quit();
    }
}
