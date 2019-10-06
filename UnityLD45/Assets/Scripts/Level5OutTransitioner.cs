using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level5OutTransitioner : LevelControllerBase
{
    // Start is called before the first frame update
    void Start()
    {
        SceneManager.LoadScene("LevelsEnd");
    }

    // Update is called once per frame
    void Update()
    {
        SceneManager.LoadScene("LevelsEnd");
    }
}
