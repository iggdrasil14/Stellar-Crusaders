using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VisibilityController : MonoBehaviour
{

    public GameObject historyPageOne; // Переменная для объекта HistoryPageOne
    public GameObject historyPageTwo;
    public GameObject historyPageTree;
    public GameObject historyPageFour;
    public GameObject historyPageFive;
    public GameObject historyPageSix;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SlideChenger());
    }

   

    private IEnumerator SlideChenger()
    {
        yield return new WaitForSeconds(2);
        historyPageOne.SetActive(false);
        historyPageTwo.SetActive(true);

        yield return new WaitForSeconds(2);
        historyPageTwo.SetActive(false);
        historyPageTree.SetActive(true);

        yield return new WaitForSeconds(2);
        historyPageTree.SetActive(false);
        historyPageFour.SetActive(true);

        yield return new WaitForSeconds(2);
        historyPageFour.SetActive(false);
        historyPageFive.SetActive(true);

        yield return new WaitForSeconds(2);
        historyPageFive.SetActive(false);
        historyPageSix.SetActive(true);

        yield return new WaitForSeconds(2);
        historyPageSix.SetActive(true);
        GameStart();
    }
    public void GameStart()
    {
        SceneManager.LoadScene(2);
    }
}
