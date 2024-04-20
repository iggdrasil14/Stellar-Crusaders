using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public void ExitGame()
    {
        // Выход из игры
        Application.Quit();
        Debug.Log("Выход...");
    }
}
