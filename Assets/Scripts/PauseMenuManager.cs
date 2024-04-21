using UnityEngine;
using UnityEngine.Events;

// ����� PauseMenuManager ��������� ���� ����� � ���� [1]
public class PauseMenuManager : MonoBehaviour
{
    // ������ UI ��� ���� ����� [2]
    public GameObject pauseMenuUI;
    // �������, ������� ���������� ��� ����� ���� [9]
    public UnityEvent OnGamePaused;
    // �������, ������� ���������� ��� ������������� ���� [10]

    public UnityEvent OnGameResumed;

    // ����������, ������� �����������, ��������� �� ���� �� ����� [7]
    private bool isPaused = false;

    // ���� ����� ���������� ��� ������� ����� � �������� ������� ������������� ���� [8]
    private void Start()
    {
        OnGameResumed.Invoke();
    }

    // ���� ����� ���������� ������ ���� � ��������� ������� ������ Escape ��� ���������� ������ ���� [3]
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

    // ���� ����� ������������ ����, ��������� ���� ����� � ��������������� ������� �������� ������� [4]
    public void ResumeGame()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;

        OnGameResumed.Invoke();
    }

    // ���� ����� ������ ���� �� �����, ���������� ���� ����� � ������������� �������� ������� �� 0 [5]
    public void PauseGame()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;

        OnGamePaused.Invoke();
    }

    // ���� ����� �������� ����� �� ���� [11]
    public void QuitGame()
    {
        Application.Quit();
    }
}