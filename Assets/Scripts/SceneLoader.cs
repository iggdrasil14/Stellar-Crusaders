using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(1);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.UnloadSceneAsync(1);
        }
    }

    public void GameStart()
    {
        SceneManager.LoadScene(1);
    }
}
