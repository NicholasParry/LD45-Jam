using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1 : MonoBehaviour
{
    private bool runningCo;

    public float WaitTime = 2;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Test");
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.anyKey && !runningCo)
        {
            StartCoroutine(AnyKeyWait());
        }
    }

    IEnumerator AnyKeyWait()
    {
        
        runningCo = true; 
        yield return new WaitForSeconds(WaitTime);
        runningCo = false;
        if (Input.anyKey)
        {
            Debug.Log("Level 1 complete");
            SceneManager.LoadScene("Level2");
        }
    }
}
