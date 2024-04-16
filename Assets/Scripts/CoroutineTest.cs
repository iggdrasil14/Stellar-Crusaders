using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            StartCoroutine(ScaleChange());
        }
    }

    private IEnumerator ScaleChange()
    {
        //yield return new WaitForSeconds(3);
        //transform.localScale = Vector3.one * 10;

        //yield return new WaitForSeconds(5);
        //transform.localScale = Vector3.one;

        float delta = 1;

        while (transform.localScale.x <= 10 - 0.1f)
        {
            yield return new WaitForEndOfFrame();
            delta += Time.deltaTime;
            //transform.localScale = Vector3.one *delta;
            //transform.localScale = Vector3.Lerp(transform.localScale, Vector3.one * 10, Time.deltaTime * 3);
            transform.localScale = Vector3.MoveTowards(transform.localScale, Vector3.one * 10, Time.deltaTime * 3);
        }

        transform.localScale = Vector3.one * 10;

        Debug.Log("!!!");
    }
}
