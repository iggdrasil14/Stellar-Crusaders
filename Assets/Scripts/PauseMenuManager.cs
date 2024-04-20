using UnityEngine;

public class PauseMenuManager : MonoBehaviour
{
    public GameObject pauseMenuUI;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseGame();       
        }
    }

    public void ResumeGame()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f; // Возобновляет нормальное течение времени
    }

    public void PauseGame()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f; // Останавливает игру
    }

    public void QuitGame()
    {
        Application.Quit(); // Закрытие игры
    }
}
