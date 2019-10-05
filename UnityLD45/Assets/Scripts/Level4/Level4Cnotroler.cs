using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level4Cnotroler : LevelControllerBase
{

    public GameObject[] enemysToKill;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {




        foreach(GameObject go in enemysToKill)
        {
            if (go)
            {
                return;
            }
        }
        SceneManager.LoadScene("Level5");
    }

    public override void OnLocalReset()
    {
        SceneManager.LoadScene("Level4");
    }
}
