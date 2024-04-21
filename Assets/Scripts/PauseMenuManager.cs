using UnityEngine;
using UnityEngine.Events;

// Класс PauseMenuManager управляет меню паузы в игре [1]
public class PauseMenuManager : MonoBehaviour
{
    // Объект UI для меню паузы [2]
    public GameObject pauseMenuUI;
    // Событие, которое вызывается при паузе игры [9]
    public UnityEvent OnGamePaused;
    // Событие, которое вызывается при возобновлении игры [10]

    public UnityEvent OnGameResumed;

    // Переменная, которая отслеживает, находится ли игра на паузе [7]
    private bool isPaused = false;

    // Этот метод вызывается при запуске сцены и вызывает событие возобновления игры [8]
    private void Start()
    {
        OnGameResumed.Invoke();
    }

    // Этот метод вызывается каждый кадр и проверяет нажатие кнопки Escape для управления паузой игры [3]
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    // Этот метод возобновляет игру, отключает меню паузы и восстанавливает обычную скорость времени [4]
    public void ResumeGame()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;

        OnGameResumed.Invoke();
    }

    // Этот метод ставит игру на паузу, активирует меню паузы и устанавливает скорость времени на 0 [5]
    public void PauseGame()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;

        OnGamePaused.Invoke();
    }

    // Этот метод вызывает выход из игры [11]
    public void QuitGame()
    {
        Application.Quit();
    }
}